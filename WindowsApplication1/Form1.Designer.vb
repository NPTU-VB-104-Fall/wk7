<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdItem1 = New System.Windows.Forms.Button()
        Me.cmdItem2 = New System.Windows.Forms.Button()
        Me.cmdItem3 = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.cmdReplay = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdItem1
        '
        Me.cmdItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdItem1.Location = New System.Drawing.Point(43, 44)
        Me.cmdItem1.Name = "cmdItem1"
        Me.cmdItem1.Size = New System.Drawing.Size(152, 157)
        Me.cmdItem1.TabIndex = 0
        Me.cmdItem1.UseVisualStyleBackColor = True
        '
        'cmdItem2
        '
        Me.cmdItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdItem2.Location = New System.Drawing.Point(219, 44)
        Me.cmdItem2.Name = "cmdItem2"
        Me.cmdItem2.Size = New System.Drawing.Size(152, 157)
        Me.cmdItem2.TabIndex = 1
        Me.cmdItem2.UseVisualStyleBackColor = True
        '
        'cmdItem3
        '
        Me.cmdItem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdItem3.Location = New System.Drawing.Point(397, 44)
        Me.cmdItem3.Name = "cmdItem3"
        Me.cmdItem3.Size = New System.Drawing.Size(152, 157)
        Me.cmdItem3.TabIndex = 2
        Me.cmdItem3.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(52, 259)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(51, 19)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.Text = "Play~"
        '
        'cmdReplay
        '
        Me.cmdReplay.Location = New System.Drawing.Point(168, 326)
        Me.cmdReplay.Name = "cmdReplay"
        Me.cmdReplay.Size = New System.Drawing.Size(75, 43)
        Me.cmdReplay.TabIndex = 4
        Me.cmdReplay.Text = "Replay"
        Me.cmdReplay.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(342, 326)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 43)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 400)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReplay)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.cmdItem3)
        Me.Controls.Add(Me.cmdItem2)
        Me.Controls.Add(Me.cmdItem1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Play Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdItem1 As System.Windows.Forms.Button
    Friend WithEvents cmdItem2 As System.Windows.Forms.Button
    Friend WithEvents cmdItem3 As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents cmdReplay As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class
