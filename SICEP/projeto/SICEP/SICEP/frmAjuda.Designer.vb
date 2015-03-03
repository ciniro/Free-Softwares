<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjuda))
        Me.wbNavegador = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'wbNavegador
        '
        Me.wbNavegador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbNavegador.Location = New System.Drawing.Point(0, 0)
        Me.wbNavegador.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbNavegador.Name = "wbNavegador"
        Me.wbNavegador.Size = New System.Drawing.Size(528, 501)
        Me.wbNavegador.TabIndex = 0
        Me.wbNavegador.Url = New System.Uri("C:\Arquivos de programas\SICEP\Ajuda\index.html", System.UriKind.Absolute)
        '
        'frmAjuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 501)
        Me.Controls.Add(Me.wbNavegador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAjuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuda do SICEP 1.0"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbNavegador As System.Windows.Forms.WebBrowser
End Class
