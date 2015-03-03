<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalendario))
        Me.calCalendario = New System.Windows.Forms.MonthCalendar
        Me.ajuda = New System.Windows.Forms.HelpProvider
        Me.SuspendLayout()
        '
        'calCalendario
        '
        Me.calCalendario.CalendarDimensions = New System.Drawing.Size(3, 3)
        Me.calCalendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ajuda.SetHelpString(Me.calCalendario, "Clique sobre as setas no topo para navegar de ano em ano. Clique sobre o dia na p" & _
                "arte inferior para voltar ao contexto da data atual.")
        Me.calCalendario.Location = New System.Drawing.Point(0, 0)
        Me.calCalendario.Name = "calCalendario"
        Me.ajuda.SetShowHelp(Me.calCalendario, True)
        Me.calCalendario.TabIndex = 0
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmFerramentas.html"
        '
        'frmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 444)
        Me.Controls.Add(Me.calCalendario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendário"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents calCalendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
