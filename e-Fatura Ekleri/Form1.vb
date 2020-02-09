Imports System.Xml.Linq
Imports System.IO
Public Class eFatura_Main
    Dim Ek_DosyaTipi As String
    Dim Ek_DosyaAdi As String
    Dim Ek_DosyaKodlama As String
    Dim Ek_Dosya_Icerik As String
    Dim Dosya_XML As Xml.XmlReader

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlg_Dosya_Ac.FileOk
        Dosya.Text = dlg_Dosya_Ac.FileName
    End Sub
    Private Sub Dosya_Yaz(Dosya_Adi As String)
        Dim yazilacakDosya As New FileStream(Dosya_Adi, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write)
        Dim buffer(999) As Byte
        Dim readBytes As Integer = 0
        Dim bw As New BinaryWriter(yazilacakDosya)

        readBytes = Dosya_XML.ReadElementContentAsBase64(buffer, 0, 900)

        While (readBytes > 0)
            bw.Write(buffer, 0, readBytes)
            readBytes = Dosya_XML.ReadElementContentAsBase64(buffer, 0, 900)
        End While
        yazilacakDosya.Close()
    End Sub
    Private Sub dgm_Dosya_Click(sender As Object, e As EventArgs) Handles dgm_Dosya.Click
        dlg_Dosya_Ac.ShowDialog()
    End Sub

    Private Sub dgm_Dizin_Click(sender As Object, e As EventArgs) Handles dgm_Dizin.Click
        dlg_Dizn.ShowDialog()
        Dizin.Text = dlg_Dizn.SelectedPath
    End Sub

    Private Sub dlg_Dizn_HelpRequest(sender As Object, e As EventArgs) Handles dlg_Dizn.HelpRequest

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo Hata
        WebBrowser1.Navigate("")
        btn_Yazdir.Enabled = False
        lb_FaturaEkleri.Items.Clear()
        If Not File.Exists(Dosya.Text) Then
            MsgBox("e-Fatura dosyası bulunamadı. Lütfen kontrol ediniz.")
            Dosya.Focus()
            Exit Sub
        End If
        If Not Directory.Exists(Dizin.Text) Then
            MsgBox("Eklerin oluşturulacağı dizin bulunamadı. Lütfen kontrol ediniz.")
            Dizin.Focus()
            Exit Sub
        End If
        Dosya_XML = System.Xml.XmlReader.Create(Dosya.Text)
        Do While Not Dosya_XML.EOF
            Dosya_XML.Read()
            If InStr(Dosya_XML.LocalName, "EmbeddedDocumentBinaryObject") > 0 Then
                Ek_DosyaTipi = Dosya_XML.GetAttribute("mimeCode")
                If Dizin.Text.EndsWith("\") Then Ek_DosyaAdi = Dizin.Text & Dosya_XML.GetAttribute("filename") Else Ek_DosyaAdi = Dizin.Text & "\" & Dosya_XML.GetAttribute("filename")
                Ek_DosyaKodlama = Dosya_XML.GetAttribute("encodingCode")
                If Ek_DosyaTipi <> "application/xml" And Ek_DosyaTipi <> Nothing Then
                    Ek_DosyaTipi = Ek_DosyaTipi
                    Dosya_Yaz(Ek_DosyaAdi)
                    lb_FaturaEkleri.Items.Add(Ek_DosyaAdi)

                End If
            End If
        Loop
        Exit Sub
Hata:
        MsgBox("Seçilen e-Fatura dosyası hatalı, lütfen kontrol ediniz.")
    End Sub

    Private Sub lb_FaturaEkleri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_FaturaEkleri.SelectedIndexChanged
        Dim Secilen As String
        Secilen = lb_FaturaEkleri.SelectedItem
        WebBrowser1.Navigate(Secilen)
        If Secilen.Length >= 0 Then btn_Yazdir.Enabled = True
    End Sub

    Private Sub eFatura_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        WebBrowser1.Width = Me.Width - 35
        WebBrowser1.Height = Me.Height - 175
        lb_FaturaEkleri.Width = Me.Width - 400
        If Me.Width > 550 Then btn_Hakkinda.Left = Me.Width - 100
    End Sub
    Private Sub btn_Hakkinda_Click(sender As Object, e As EventArgs) Handles btn_Hakkinda.Click
        SplashScreen1.ShowDialog()
    End Sub

    Private Sub btn_Yazdir_Click(sender As Object, e As EventArgs) Handles btn_Yazdir.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub
End Class
