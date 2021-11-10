<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gpxOrderInfo = New System.Windows.Forms.GroupBox()
        Me.DebugListBox = New System.Windows.Forms.ListBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.gpxBreadInfo = New System.Windows.Forms.GroupBox()
        Me.lblHoney = New System.Windows.Forms.Label()
        Me.lblGrain = New System.Windows.Forms.Label()
        Me.roxHoneyOat = New System.Windows.Forms.RadioButton()
        Me.roxGrainWheat = New System.Windows.Forms.RadioButton()
        Me.gpxSaladInfo = New System.Windows.Forms.GroupBox()
        Me.lblTunaPrice = New System.Windows.Forms.Label()
        Me.lblHamPrice = New System.Windows.Forms.Label()
        Me.lblTomatoPrice = New System.Windows.Forms.Label()
        Me.lblLettucePrice = New System.Windows.Forms.Label()
        Me.lblApplePrice = New System.Windows.Forms.Label()
        Me.ckxTuna = New System.Windows.Forms.CheckBox()
        Me.ckxHam = New System.Windows.Forms.CheckBox()
        Me.ckxTomato = New System.Windows.Forms.CheckBox()
        Me.ckxLettuce = New System.Windows.Forms.CheckBox()
        Me.ckxApple = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDiscountInfo = New System.Windows.Forms.Label()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.btnMostPop = New System.Windows.Forms.Button()
        Me.btnClearAccum = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.gpxSales = New System.Windows.Forms.GroupBox()
        Me.lblLargeSales = New System.Windows.Forms.Label()
        Me.lblAveragerSales = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtLargeSales = New System.Windows.Forms.TextBox()
        Me.txtAverageSales = New System.Windows.Forms.TextBox()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.txtNumberofOrder = New System.Windows.Forms.TextBox()
        Me.txtCusHisName = New System.Windows.Forms.TextBox()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.lblCusName = New System.Windows.Forms.Label()
        Me.gpxOrderInfo.SuspendLayout()
        Me.gpxBreadInfo.SuspendLayout()
        Me.gpxSaladInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gpxSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpxOrderInfo
        '
        Me.gpxOrderInfo.Controls.Add(Me.DebugListBox)
        Me.gpxOrderInfo.Controls.Add(Me.lblAmount)
        Me.gpxOrderInfo.Controls.Add(Me.txtAmount)
        Me.gpxOrderInfo.Controls.Add(Me.txtName)
        Me.gpxOrderInfo.Controls.Add(Me.lstQuantity)
        Me.gpxOrderInfo.Controls.Add(Me.lblName)
        Me.gpxOrderInfo.Controls.Add(Me.lblQuantity)
        Me.gpxOrderInfo.Controls.Add(Me.btnClear)
        Me.gpxOrderInfo.Controls.Add(Me.btnConfirm)
        Me.gpxOrderInfo.Controls.Add(Me.gpxBreadInfo)
        Me.gpxOrderInfo.Controls.Add(Me.gpxSaladInfo)
        Me.gpxOrderInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gpxOrderInfo.Location = New System.Drawing.Point(12, 68)
        Me.gpxOrderInfo.Name = "gpxOrderInfo"
        Me.gpxOrderInfo.Size = New System.Drawing.Size(662, 256)
        Me.gpxOrderInfo.TabIndex = 0
        Me.gpxOrderInfo.TabStop = False
        Me.gpxOrderInfo.Text = "Current Order Information"
        '
        'DebugListBox
        '
        Me.DebugListBox.FormattingEnabled = True
        Me.DebugListBox.ItemHeight = 15
        Me.DebugListBox.Location = New System.Drawing.Point(504, 72)
        Me.DebugListBox.Name = "DebugListBox"
        Me.DebugListBox.Size = New System.Drawing.Size(120, 94)
        Me.DebugListBox.TabIndex = 10
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAmount.Location = New System.Drawing.Point(475, 35)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(64, 15)
        Me.lblAmount.TabIndex = 9
        Me.lblAmount.Text = "Order amt:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(545, 32)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(100, 23)
        Me.txtAmount.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(369, 172)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(112, 23)
        Me.txtName.TabIndex = 7
        '
        'lstQuantity
        '
        Me.lstQuantity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstQuantity.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.ItemHeight = 15
        Me.lstQuantity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.lstQuantity.Location = New System.Drawing.Point(369, 147)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(100, 19)
        Me.lstQuantity.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(269, 175)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 15)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Customer Name"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(310, 147)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQuantity.Size = New System.Drawing.Size(53, 15)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Quantity"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(549, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Order"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(464, 215)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'gpxBreadInfo
        '
        Me.gpxBreadInfo.Controls.Add(Me.lblHoney)
        Me.gpxBreadInfo.Controls.Add(Me.lblGrain)
        Me.gpxBreadInfo.Controls.Add(Me.roxHoneyOat)
        Me.gpxBreadInfo.Controls.Add(Me.roxGrainWheat)
        Me.gpxBreadInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gpxBreadInfo.Location = New System.Drawing.Point(269, 32)
        Me.gpxBreadInfo.Name = "gpxBreadInfo"
        Me.gpxBreadInfo.Size = New System.Drawing.Size(200, 100)
        Me.gpxBreadInfo.TabIndex = 1
        Me.gpxBreadInfo.TabStop = False
        Me.gpxBreadInfo.Text = "Selecton of Bread "
        '
        'lblHoney
        '
        Me.lblHoney.AutoSize = True
        Me.lblHoney.Location = New System.Drawing.Point(103, 62)
        Me.lblHoney.Name = "lblHoney"
        Me.lblHoney.Size = New System.Drawing.Size(35, 15)
        Me.lblHoney.TabIndex = 4
        Me.lblHoney.Text = "Label"
        '
        'lblGrain
        '
        Me.lblGrain.AutoSize = True
        Me.lblGrain.Location = New System.Drawing.Point(103, 25)
        Me.lblGrain.Name = "lblGrain"
        Me.lblGrain.Size = New System.Drawing.Size(35, 15)
        Me.lblGrain.TabIndex = 2
        Me.lblGrain.Text = "Label"
        '
        'roxHoneyOat
        '
        Me.roxHoneyOat.AutoSize = True
        Me.roxHoneyOat.Location = New System.Drawing.Point(7, 58)
        Me.roxHoneyOat.Name = "roxHoneyOat"
        Me.roxHoneyOat.Size = New System.Drawing.Size(82, 19)
        Me.roxHoneyOat.TabIndex = 1
        Me.roxHoneyOat.TabStop = True
        Me.roxHoneyOat.Text = "Honey Oat"
        Me.roxHoneyOat.UseVisualStyleBackColor = True
        '
        'roxGrainWheat
        '
        Me.roxGrainWheat.AutoSize = True
        Me.roxGrainWheat.Location = New System.Drawing.Point(7, 23)
        Me.roxGrainWheat.Name = "roxGrainWheat"
        Me.roxGrainWheat.Size = New System.Drawing.Size(90, 19)
        Me.roxGrainWheat.TabIndex = 0
        Me.roxGrainWheat.TabStop = True
        Me.roxGrainWheat.Text = "Grain Wheat"
        Me.roxGrainWheat.UseVisualStyleBackColor = True
        '
        'gpxSaladInfo
        '
        Me.gpxSaladInfo.Controls.Add(Me.lblTunaPrice)
        Me.gpxSaladInfo.Controls.Add(Me.lblHamPrice)
        Me.gpxSaladInfo.Controls.Add(Me.lblTomatoPrice)
        Me.gpxSaladInfo.Controls.Add(Me.lblLettucePrice)
        Me.gpxSaladInfo.Controls.Add(Me.lblApplePrice)
        Me.gpxSaladInfo.Controls.Add(Me.ckxTuna)
        Me.gpxSaladInfo.Controls.Add(Me.ckxHam)
        Me.gpxSaladInfo.Controls.Add(Me.ckxTomato)
        Me.gpxSaladInfo.Controls.Add(Me.ckxLettuce)
        Me.gpxSaladInfo.Controls.Add(Me.ckxApple)
        Me.gpxSaladInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.gpxSaladInfo.Location = New System.Drawing.Point(19, 23)
        Me.gpxSaladInfo.Name = "gpxSaladInfo"
        Me.gpxSaladInfo.Size = New System.Drawing.Size(205, 227)
        Me.gpxSaladInfo.TabIndex = 0
        Me.gpxSaladInfo.TabStop = False
        Me.gpxSaladInfo.Text = "Selecton of Salad Ingredients"
        '
        'lblTunaPrice
        '
        Me.lblTunaPrice.AutoSize = True
        Me.lblTunaPrice.Location = New System.Drawing.Point(109, 136)
        Me.lblTunaPrice.Name = "lblTunaPrice"
        Me.lblTunaPrice.Size = New System.Drawing.Size(35, 15)
        Me.lblTunaPrice.TabIndex = 9
        Me.lblTunaPrice.Text = "Label"
        Me.lblTunaPrice.Visible = False
        '
        'lblHamPrice
        '
        Me.lblHamPrice.AutoSize = True
        Me.lblHamPrice.Location = New System.Drawing.Point(109, 110)
        Me.lblHamPrice.Name = "lblHamPrice"
        Me.lblHamPrice.Size = New System.Drawing.Size(35, 15)
        Me.lblHamPrice.TabIndex = 8
        Me.lblHamPrice.Text = "Label"
        Me.lblHamPrice.Visible = False
        '
        'lblTomatoPrice
        '
        Me.lblTomatoPrice.AutoSize = True
        Me.lblTomatoPrice.Location = New System.Drawing.Point(109, 84)
        Me.lblTomatoPrice.Name = "lblTomatoPrice"
        Me.lblTomatoPrice.Size = New System.Drawing.Size(35, 15)
        Me.lblTomatoPrice.TabIndex = 7
        Me.lblTomatoPrice.Text = "Label"
        Me.lblTomatoPrice.Visible = False
        '
        'lblLettucePrice
        '
        Me.lblLettucePrice.AutoSize = True
        Me.lblLettucePrice.Location = New System.Drawing.Point(109, 58)
        Me.lblLettucePrice.Name = "lblLettucePrice"
        Me.lblLettucePrice.Size = New System.Drawing.Size(35, 15)
        Me.lblLettucePrice.TabIndex = 6
        Me.lblLettucePrice.Text = "Label"
        Me.lblLettucePrice.Visible = False
        '
        'lblApplePrice
        '
        Me.lblApplePrice.AutoSize = True
        Me.lblApplePrice.Location = New System.Drawing.Point(109, 32)
        Me.lblApplePrice.Name = "lblApplePrice"
        Me.lblApplePrice.Size = New System.Drawing.Size(35, 15)
        Me.lblApplePrice.TabIndex = 5
        Me.lblApplePrice.Text = "Label"
        Me.lblApplePrice.Visible = False
        '
        'ckxTuna
        '
        Me.ckxTuna.AutoSize = True
        Me.ckxTuna.Location = New System.Drawing.Point(7, 135)
        Me.ckxTuna.Name = "ckxTuna"
        Me.ckxTuna.Size = New System.Drawing.Size(112, 19)
        Me.ckxTuna.TabIndex = 4
        Me.ckxTuna.Text = "Tuna------------"
        Me.ckxTuna.UseVisualStyleBackColor = True
        '
        'ckxHam
        '
        Me.ckxHam.AutoSize = True
        Me.ckxHam.Location = New System.Drawing.Point(7, 109)
        Me.ckxHam.Name = "ckxHam"
        Me.ckxHam.Size = New System.Drawing.Size(112, 19)
        Me.ckxHam.TabIndex = 3
        Me.ckxHam.Text = "Ham------------"
        Me.ckxHam.UseVisualStyleBackColor = True
        '
        'ckxTomato
        '
        Me.ckxTomato.AutoSize = True
        Me.ckxTomato.Location = New System.Drawing.Point(7, 83)
        Me.ckxTomato.Name = "ckxTomato"
        Me.ckxTomato.Size = New System.Drawing.Size(111, 19)
        Me.ckxTomato.TabIndex = 2
        Me.ckxTomato.Text = "Tomato---------"
        Me.ckxTomato.UseVisualStyleBackColor = True
        '
        'ckxLettuce
        '
        Me.ckxLettuce.AutoSize = True
        Me.ckxLettuce.Location = New System.Drawing.Point(7, 57)
        Me.ckxLettuce.Name = "ckxLettuce"
        Me.ckxLettuce.Size = New System.Drawing.Size(115, 19)
        Me.ckxLettuce.TabIndex = 1
        Me.ckxLettuce.Text = "Lettuce----------"
        Me.ckxLettuce.UseVisualStyleBackColor = True
        '
        'ckxApple
        '
        Me.ckxApple.AutoSize = True
        Me.ckxApple.Location = New System.Drawing.Point(7, 31)
        Me.ckxApple.Name = "ckxApple"
        Me.ckxApple.Size = New System.Drawing.Size(112, 19)
        Me.ckxApple.TabIndex = 0
        Me.ckxApple.Text = "Apple-----------"
        Me.ckxApple.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblDiscountInfo)
        Me.Panel1.Location = New System.Drawing.Point(281, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 49)
        Me.Panel1.TabIndex = 1
        '
        'lblDiscountInfo
        '
        Me.lblDiscountInfo.AutoSize = True
        Me.lblDiscountInfo.Location = New System.Drawing.Point(3, 0)
        Me.lblDiscountInfo.Name = "lblDiscountInfo"
        Me.lblDiscountInfo.Size = New System.Drawing.Size(237, 30)
        Me.lblDiscountInfo.TabIndex = 4
        Me.lblDiscountInfo.Text = "Discount Offered per Order:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10.00% discount if order amount >=$100.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lstHistory
        '
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.ItemHeight = 15
        Me.lstHistory.Location = New System.Drawing.Point(704, 91)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(120, 289)
        Me.lstHistory.TabIndex = 2
        '
        'btnMostPop
        '
        Me.btnMostPop.Location = New System.Drawing.Point(475, 21)
        Me.btnMostPop.Name = "btnMostPop"
        Me.btnMostPop.Size = New System.Drawing.Size(152, 23)
        Me.btnMostPop.TabIndex = 3
        Me.btnMostPop.Text = "Most Popluar Ingredients"
        Me.btnMostPop.UseVisualStyleBackColor = True
        '
        'btnClearAccum
        '
        Me.btnClearAccum.Location = New System.Drawing.Point(476, 64)
        Me.btnClearAccum.Name = "btnClearAccum"
        Me.btnClearAccum.Size = New System.Drawing.Size(148, 23)
        Me.btnClearAccum.TabIndex = 4
        Me.btnClearAccum.Text = "Clear Accumulation"
        Me.btnClearAccum.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(788, 406)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(48, 23)
        Me.btnFind.TabIndex = 5
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'gpxSales
        '
        Me.gpxSales.Controls.Add(Me.lblLargeSales)
        Me.gpxSales.Controls.Add(Me.lblAveragerSales)
        Me.gpxSales.Controls.Add(Me.lblTotalSales)
        Me.gpxSales.Controls.Add(Me.lblNum)
        Me.gpxSales.Controls.Add(Me.txtLargeSales)
        Me.gpxSales.Controls.Add(Me.txtAverageSales)
        Me.gpxSales.Controls.Add(Me.txtTotalSales)
        Me.gpxSales.Controls.Add(Me.txtNumberofOrder)
        Me.gpxSales.Controls.Add(Me.btnClearAccum)
        Me.gpxSales.Controls.Add(Me.btnMostPop)
        Me.gpxSales.Location = New System.Drawing.Point(12, 338)
        Me.gpxSales.Name = "gpxSales"
        Me.gpxSales.Size = New System.Drawing.Size(633, 100)
        Me.gpxSales.TabIndex = 6
        Me.gpxSales.TabStop = False
        Me.gpxSales.Text = "Accumulated Sales"
        '
        'lblLargeSales
        '
        Me.lblLargeSales.AutoSize = True
        Me.lblLargeSales.Location = New System.Drawing.Point(269, 68)
        Me.lblLargeSales.Name = "lblLargeSales"
        Me.lblLargeSales.Size = New System.Drawing.Size(74, 15)
        Me.lblLargeSales.TabIndex = 12
        Me.lblLargeSales.Text = "Largest Sales"
        '
        'lblAveragerSales
        '
        Me.lblAveragerSales.AutoSize = True
        Me.lblAveragerSales.Location = New System.Drawing.Point(269, 30)
        Me.lblAveragerSales.Name = "lblAveragerSales"
        Me.lblAveragerSales.Size = New System.Drawing.Size(93, 15)
        Me.lblAveragerSales.TabIndex = 11
        Me.lblAveragerSales.Text = "Average of Sales"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(19, 72)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(61, 15)
        Me.lblTotalSales.TabIndex = 10
        Me.lblTotalSales.Text = "Total Sales"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(19, 30)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(103, 15)
        Me.lblNum.TabIndex = 9
        Me.lblNum.Text = "Number of Orders"
        '
        'txtLargeSales
        '
        Me.txtLargeSales.Location = New System.Drawing.Point(369, 65)
        Me.txtLargeSales.Name = "txtLargeSales"
        Me.txtLargeSales.Size = New System.Drawing.Size(100, 23)
        Me.txtLargeSales.TabIndex = 8
        '
        'txtAverageSales
        '
        Me.txtAverageSales.Location = New System.Drawing.Point(369, 22)
        Me.txtAverageSales.Name = "txtAverageSales"
        Me.txtAverageSales.ReadOnly = True
        Me.txtAverageSales.Size = New System.Drawing.Size(100, 23)
        Me.txtAverageSales.TabIndex = 7
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(128, 65)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalSales.TabIndex = 6
        '
        'txtNumberofOrder
        '
        Me.txtNumberofOrder.Location = New System.Drawing.Point(128, 22)
        Me.txtNumberofOrder.Name = "txtNumberofOrder"
        Me.txtNumberofOrder.Size = New System.Drawing.Size(100, 23)
        Me.txtNumberofOrder.TabIndex = 5
        '
        'txtCusHisName
        '
        Me.txtCusHisName.Location = New System.Drawing.Point(654, 403)
        Me.txtCusHisName.Name = "txtCusHisName"
        Me.txtCusHisName.Size = New System.Drawing.Size(95, 23)
        Me.txtCusHisName.TabIndex = 7
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Location = New System.Drawing.Point(704, 68)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(100, 15)
        Me.lblHistory.TabIndex = 8
        Me.lblHistory.Text = "Customer History"
        '
        'lblCusName
        '
        Me.lblCusName.AutoSize = True
        Me.lblCusName.Location = New System.Drawing.Point(651, 385)
        Me.lblCusName.Name = "lblCusName"
        Me.lblCusName.Size = New System.Drawing.Size(97, 15)
        Me.lblCusName.TabIndex = 9
        Me.lblCusName.Text = "Customer Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 450)
        Me.Controls.Add(Me.lblCusName)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.txtCusHisName)
        Me.Controls.Add(Me.gpxSales)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lstHistory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpxOrderInfo)
        Me.Name = "Form1"
        Me.Text = "Coffee Shop"
        Me.gpxOrderInfo.ResumeLayout(False)
        Me.gpxOrderInfo.PerformLayout()
        Me.gpxBreadInfo.ResumeLayout(False)
        Me.gpxBreadInfo.PerformLayout()
        Me.gpxSaladInfo.ResumeLayout(False)
        Me.gpxSaladInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gpxSales.ResumeLayout(False)
        Me.gpxSales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents gpxBreadInfo As GroupBox
    Friend WithEvents gpxSaladInfo As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDiscountInfo As Label
    Friend WithEvents lstHistory As ListBox
    Friend WithEvents btnMostPop As Button
    Friend WithEvents btnClearAccum As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents gpxSales As GroupBox
    Friend WithEvents lblLargeSales As Label
    Friend WithEvents lblAveragerSales As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents txtLargeSales As TextBox
    Friend WithEvents txtAverageSales As TextBox
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents txtNumberofOrder As TextBox
    Friend WithEvents txtCusHisName As TextBox
    Friend WithEvents lblHistory As Label
    Friend WithEvents lblCusName As Label
    Friend WithEvents roxHoneyOat As RadioButton
    Friend WithEvents roxGrainWheat As RadioButton
    Friend WithEvents lblTunaPrice As Label
    Friend WithEvents lblHamPrice As Label
    Friend WithEvents lblTomatoPrice As Label
    Friend WithEvents lblLettucePrice As Label
    Friend WithEvents lblApplePrice As Label
    Friend WithEvents ckxTuna As CheckBox
    Friend WithEvents ckxHam As CheckBox
    Friend WithEvents ckxTomato As CheckBox
    Friend WithEvents ckxLettuce As CheckBox
    Friend WithEvents ckxApple As CheckBox
    Private WithEvents gpxOrderInfo As GroupBox
    Friend WithEvents lblHoney As Label
    Friend WithEvents lblGrain As Label
    Friend WithEvents DebugListBox As ListBox
End Class
