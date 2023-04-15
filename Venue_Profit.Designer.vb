<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venue_Profit
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.eventgrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.eventgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orange
        Me.Button4.Location = New System.Drawing.Point(60, 55)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 31)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'eventgrid
        '
        Me.eventgrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.eventgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.eventgrid.Location = New System.Drawing.Point(173, 72)
        Me.eventgrid.Name = "eventgrid"
        Me.eventgrid.Size = New System.Drawing.Size(341, 294)
        Me.eventgrid.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Note : This form is only for Viewing!"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSalmon
        Me.Button5.Location = New System.Drawing.Point(517, 408)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 30)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Back To Main Form"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Venue_Profit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.eventgrid)
        Me.Controls.Add(Me.Button4)
        Me.Name = "Venue_Profit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venue_Profit"
        CType(Me.eventgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents eventgrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
End Class
