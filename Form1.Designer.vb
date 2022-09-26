<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockWatch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstStocks2 = New System.Windows.Forms.TextBox()
        Me.Profitability = New System.Windows.Forms.Button()
        Me.lstOgPrice = New System.Windows.Forms.ListBox()
        Me.lstCurrentStock = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstCurrentPrice = New System.Windows.Forms.ListBox()
        Me.lstNumberOfShares = New System.Windows.Forms.ListBox()
        Me.lstNumberShare = New System.Windows.Forms.ListBox()
        Me.lstNET = New System.Windows.Forms.ListBox()
        Me.lstNetLoss = New System.Windows.Forms.ListBox()
        Me.lstNameOfStock = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstStocks2
        '
        Me.lstStocks2.Location = New System.Drawing.Point(343, 20)
        Me.lstStocks2.Name = "lstStocks2"
        Me.lstStocks2.Size = New System.Drawing.Size(100, 23)
        Me.lstStocks2.TabIndex = 0
        Me.lstStocks2.Text = "Stock"
        '
        'Profitability
        '
        Me.Profitability.Location = New System.Drawing.Point(357, 255)
        Me.Profitability.Name = "Profitability"
        Me.Profitability.Size = New System.Drawing.Size(75, 42)
        Me.Profitability.TabIndex = 1
        Me.Profitability.Text = "Profitibality"
        Me.Profitability.UseVisualStyleBackColor = True
        '
        'lstOgPrice
        '
        Me.lstOgPrice.FormattingEnabled = True
        Me.lstOgPrice.ItemHeight = 15
        Me.lstOgPrice.Location = New System.Drawing.Point(263, 97)
        Me.lstOgPrice.Name = "lstOgPrice"
        Me.lstOgPrice.Size = New System.Drawing.Size(120, 19)
        Me.lstOgPrice.TabIndex = 5
        '
        'lstCurrentStock
        '
        Me.lstCurrentStock.FormattingEnabled = True
        Me.lstCurrentStock.ItemHeight = 15
        Me.lstCurrentStock.Location = New System.Drawing.Point(263, 136)
        Me.lstCurrentStock.Name = "lstCurrentStock"
        Me.lstCurrentStock.Size = New System.Drawing.Size(120, 19)
        Me.lstCurrentStock.TabIndex = 6
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 15
        Me.lstPrice.Location = New System.Drawing.Point(405, 97)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(96, 19)
        Me.lstPrice.TabIndex = 8
        '
        'lstCurrentPrice
        '
        Me.lstCurrentPrice.FormattingEnabled = True
        Me.lstCurrentPrice.ItemHeight = 15
        Me.lstCurrentPrice.Location = New System.Drawing.Point(405, 136)
        Me.lstCurrentPrice.Name = "lstCurrentPrice"
        Me.lstCurrentPrice.Size = New System.Drawing.Size(96, 19)
        Me.lstCurrentPrice.TabIndex = 9
        '
        'lstNumberOfShares
        '
        Me.lstNumberOfShares.FormattingEnabled = True
        Me.lstNumberOfShares.ItemHeight = 15
        Me.lstNumberOfShares.Location = New System.Drawing.Point(263, 175)
        Me.lstNumberOfShares.Name = "lstNumberOfShares"
        Me.lstNumberOfShares.Size = New System.Drawing.Size(120, 19)
        Me.lstNumberOfShares.TabIndex = 10
        '
        'lstNumberShare
        '
        Me.lstNumberShare.FormattingEnabled = True
        Me.lstNumberShare.ItemHeight = 15
        Me.lstNumberShare.Location = New System.Drawing.Point(405, 175)
        Me.lstNumberShare.Name = "lstNumberShare"
        Me.lstNumberShare.Size = New System.Drawing.Size(96, 19)
        Me.lstNumberShare.TabIndex = 11
        '
        'lstNET
        '
        Me.lstNET.FormattingEnabled = True
        Me.lstNET.ItemHeight = 15
        Me.lstNET.Location = New System.Drawing.Point(263, 214)
        Me.lstNET.Name = "lstNET"
        Me.lstNET.Size = New System.Drawing.Size(120, 19)
        Me.lstNET.TabIndex = 12
        '
        'lstNetLoss
        '
        Me.lstNetLoss.FormattingEnabled = True
        Me.lstNetLoss.ItemHeight = 15
        Me.lstNetLoss.Location = New System.Drawing.Point(405, 214)
        Me.lstNetLoss.Name = "lstNetLoss"
        Me.lstNetLoss.Size = New System.Drawing.Size(96, 19)
        Me.lstNetLoss.TabIndex = 13
        '
        'lstNameOfStock
        '
        Me.lstNameOfStock.FormattingEnabled = True
        Me.lstNameOfStock.ItemHeight = 15
        Me.lstNameOfStock.Location = New System.Drawing.Point(334, 56)
        Me.lstNameOfStock.Name = "lstNameOfStock"
        Me.lstNameOfStock.Size = New System.Drawing.Size(120, 19)
        Me.lstNameOfStock.TabIndex = 14
        '
        'StockWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstNameOfStock)
        Me.Controls.Add(Me.lstNetLoss)
        Me.Controls.Add(Me.lstNET)
        Me.Controls.Add(Me.lstNumberShare)
        Me.Controls.Add(Me.lstNumberOfShares)
        Me.Controls.Add(Me.lstCurrentPrice)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstCurrentStock)
        Me.Controls.Add(Me.lstOgPrice)
        Me.Controls.Add(Me.Profitability)
        Me.Controls.Add(Me.lstStocks2)
        Me.Name = "StockWatch"
        Me.Text = "StockWatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStocks2 As TextBox
    Friend WithEvents Profitability As Button
    Friend WithEvents lstOgPrice As ListBox
    Friend WithEvents lstCurrentStock As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lstCurrentPrice As ListBox
    Friend WithEvents lstNumberOfShares As ListBox
    Friend WithEvents lstNumberShare As ListBox
    Friend WithEvents lstNET As ListBox
    Friend WithEvents lstNetLoss As ListBox
    Friend WithEvents lstNameOfStock As ListBox
End Class
