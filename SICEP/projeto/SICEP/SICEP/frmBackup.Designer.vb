<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdFazerBackup = New System.Windows.Forms.Button
        Me.lblData = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ajuda = New System.Windows.Forms.HelpProvider
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SICEP.My.Resources.Resources.informacoes
        Me.PictureBox1.Location = New System.Drawing.Point(358, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data do Último Backup:"
        '
        'cmdFazerBackup
        '
        Me.cmdFazerBackup.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdFazerBackup, "Clique aqui e todas as informações do SICEP 1.0 serão guardadas em local seguro.")
        Me.cmdFazerBackup.Location = New System.Drawing.Point(10, 155)
        Me.cmdFazerBackup.Name = "cmdFazerBackup"
        Me.ajuda.SetShowHelp(Me.cmdFazerBackup, True)
        Me.cmdFazerBackup.Size = New System.Drawing.Size(141, 43)
        Me.cmdFazerBackup.TabIndex = 3
        Me.cmdFazerBackup.Text = "Fazer Backup"
        Me.cmdFazerBackup.UseVisualStyleBackColor = False
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Red
        Me.lblData.Location = New System.Drawing.Point(155, 107)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(0, 16)
        Me.lblData.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(171, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Restaurar Backup"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmBackup.html"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(470, 210)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.cmdFazerBackup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.ajuda.SetHelpString(Me, "Neste formulário você executará o backup dos seus dados. Para isso clique sobre o" & _
                " botão FAZER BACKUP  e observe a data do último backup feito.")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackup"
        Me.ajuda.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Backup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdFazerBackup As System.Windows.Forms.Button
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
