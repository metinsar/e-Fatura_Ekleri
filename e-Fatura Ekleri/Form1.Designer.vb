<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eFatura_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eFatura_Main))
        Me.Dosya = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgm_Dosya = New System.Windows.Forms.Button()
        Me.dlg_Dosya_Ac = New System.Windows.Forms.OpenFileDialog()
        Me.lb_FaturaEkleri = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgm_Dizin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dizin = New System.Windows.Forms.TextBox()
        Me.dlg_Dizn = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btn_Hakkinda = New System.Windows.Forms.Button()
        Me.btn_Yazdir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Dosya
        '
        Me.Dosya.Location = New System.Drawing.Point(15, 25)
        Me.Dosya.Name = "Dosya"
        Me.Dosya.Size = New System.Drawing.Size(308, 20)
        Me.Dosya.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "e-Fatura Dosyası ( XML Dosya )"
        '
        'dgm_Dosya
        '
        Me.dgm_Dosya.Location = New System.Drawing.Point(329, 25)
        Me.dgm_Dosya.Name = "dgm_Dosya"
        Me.dgm_Dosya.Size = New System.Drawing.Size(28, 20)
        Me.dgm_Dosya.TabIndex = 1
        Me.dgm_Dosya.Text = "..."
        Me.dgm_Dosya.UseVisualStyleBackColor = True
        '
        'dlg_Dosya_Ac
        '
        Me.dlg_Dosya_Ac.FileName = "OpenFileDialog1"
        '
        'lb_FaturaEkleri
        '
        Me.lb_FaturaEkleri.FormattingEnabled = True
        Me.lb_FaturaEkleri.Location = New System.Drawing.Point(363, 25)
        Me.lb_FaturaEkleri.Name = "lb_FaturaEkleri"
        Me.lb_FaturaEkleri.Size = New System.Drawing.Size(469, 95)
        Me.lb_FaturaEkleri.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fatura Ekleri"
        '
        'dgm_Dizin
        '
        Me.dgm_Dizin.Location = New System.Drawing.Point(329, 62)
        Me.dgm_Dizin.Name = "dgm_Dizin"
        Me.dgm_Dizin.Size = New System.Drawing.Size(28, 20)
        Me.dgm_Dizin.TabIndex = 3
        Me.dgm_Dizin.Text = "..."
        Me.dgm_Dizin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Eklerin Oluşturulacağı Dizin"
        '
        'Dizin
        '
        Me.Dizin.Location = New System.Drawing.Point(15, 61)
        Me.Dizin.Name = "Dizin"
        Me.Dizin.Size = New System.Drawing.Size(308, 20)
        Me.Dizin.TabIndex = 2
        '
        'dlg_Dizn
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(342, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "e-Fatura Ekleri "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(15, 126)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(817, 317)
        Me.WebBrowser1.TabIndex = 7
        '
        'btn_Hakkinda
        '
        Me.btn_Hakkinda.Location = New System.Drawing.Point(725, 3)
        Me.btn_Hakkinda.Name = "btn_Hakkinda"
        Me.btn_Hakkinda.Size = New System.Drawing.Size(62, 19)
        Me.btn_Hakkinda.TabIndex = 6
        Me.btn_Hakkinda.Text = "Hakkında"
        Me.btn_Hakkinda.UseVisualStyleBackColor = True
        '
        'btn_Yazdir
        '
        Me.btn_Yazdir.Enabled = False
        Me.btn_Yazdir.Location = New System.Drawing.Point(15, 126)
        Me.btn_Yazdir.Name = "btn_Yazdir"
        Me.btn_Yazdir.Size = New System.Drawing.Size(44, 19)
        Me.btn_Yazdir.TabIndex = 8
        Me.btn_Yazdir.Text = "Yazdır"
        Me.btn_Yazdir.UseVisualStyleBackColor = True
        '
        'eFatura_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 461)
        Me.Controls.Add(Me.btn_Yazdir)
        Me.Controls.Add(Me.btn_Hakkinda)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgm_Dizin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dizin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_FaturaEkleri)
        Me.Controls.Add(Me.dgm_Dosya)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dosya)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "eFatura_Main"
        Me.Text = "e-Fatura Eki"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Dosya As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgm_Dosya As System.Windows.Forms.Button
    Friend WithEvents dlg_Dosya_Ac As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lb_FaturaEkleri As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgm_Dizin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Dizin As System.Windows.Forms.TextBox
    Friend WithEvents dlg_Dizn As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btn_Hakkinda As System.Windows.Forms.Button
    Friend WithEvents btn_Yazdir As System.Windows.Forms.Button

End Class
