<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.报告问题ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.报告新问题ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看问题列表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.检查更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.发行说明ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于与鸣谢ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_weibo = New System.Windows.Forms.RadioButton()
        Me.RadioButton_bilibili = New System.Windows.Forms.RadioButton()
        Me.RadioButton_zhihu = New System.Windows.Forms.RadioButton()
        Me.RadioButton_GooGle = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Sogou = New System.Windows.Forms.RadioButton()
        Me.RadioButton_bing = New System.Windows.Forms.RadioButton()
        Me.RadioButton_baidu = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(159, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(723, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "http://"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(888, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "->"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 89)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(870, 468)
        Me.WebBrowser1.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 569)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1037, 24)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(61, 19)
        Me.ToolStripStatusLabel1.Text = "准备就绪"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(48, 19)
        Me.ToolStripStatusLabel2.Text = "未连接"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSplitButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1037, 26)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Enabled = False
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(48, 23)
        Me.ToolStripSplitButton1.Text = "文件"
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.报告问题ToolStripMenuItem, Me.ToolStripSeparator1, Me.检查更新ToolStripMenuItem, Me.发行说明ToolStripMenuItem1, Me.ToolStripSeparator2, Me.关于与鸣谢ToolStripMenuItem})
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(48, 23)
        Me.ToolStripSplitButton2.Text = "帮助"
        '
        '报告问题ToolStripMenuItem
        '
        Me.报告问题ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.报告新问题ToolStripMenuItem, Me.查看问题列表ToolStripMenuItem})
        Me.报告问题ToolStripMenuItem.Name = "报告问题ToolStripMenuItem"
        Me.报告问题ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.报告问题ToolStripMenuItem.Text = "报告问题"
        '
        '报告新问题ToolStripMenuItem
        '
        Me.报告新问题ToolStripMenuItem.Name = "报告新问题ToolStripMenuItem"
        Me.报告新问题ToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.报告新问题ToolStripMenuItem.Text = "报告新问题"
        '
        '查看问题列表ToolStripMenuItem
        '
        Me.查看问题列表ToolStripMenuItem.Name = "查看问题列表ToolStripMenuItem"
        Me.查看问题列表ToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.查看问题列表ToolStripMenuItem.Text = "查看问题列表"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        '检查更新ToolStripMenuItem
        '
        Me.检查更新ToolStripMenuItem.Enabled = False
        Me.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem"
        Me.检查更新ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.检查更新ToolStripMenuItem.Text = "检查更新"
        '
        '发行说明ToolStripMenuItem1
        '
        Me.发行说明ToolStripMenuItem1.Name = "发行说明ToolStripMenuItem1"
        Me.发行说明ToolStripMenuItem1.Size = New System.Drawing.Size(180, 24)
        Me.发行说明ToolStripMenuItem1.Text = "发行说明"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        '关于与鸣谢ToolStripMenuItem
        '
        Me.关于与鸣谢ToolStripMenuItem.Name = "关于与鸣谢ToolStripMenuItem"
        Me.关于与鸣谢ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.关于与鸣谢ToolStripMenuItem.Text = "关于与鸣谢"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_weibo)
        Me.GroupBox1.Controls.Add(Me.RadioButton_bilibili)
        Me.GroupBox1.Controls.Add(Me.RadioButton_zhihu)
        Me.GroupBox1.Controls.Add(Me.RadioButton_GooGle)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Sogou)
        Me.GroupBox1.Controls.Add(Me.RadioButton_bing)
        Me.GroupBox1.Controls.Add(Me.RadioButton_baidu)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(888, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 151)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "默认搜索引擎"
        '
        'RadioButton_weibo
        '
        Me.RadioButton_weibo.AutoSize = True
        Me.RadioButton_weibo.Location = New System.Drawing.Point(11, 96)
        Me.RadioButton_weibo.Name = "RadioButton_weibo"
        Me.RadioButton_weibo.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_weibo.TabIndex = 7
        Me.RadioButton_weibo.Text = "微博"
        Me.RadioButton_weibo.UseVisualStyleBackColor = True
        '
        'RadioButton_bilibili
        '
        Me.RadioButton_bilibili.AutoSize = True
        Me.RadioButton_bilibili.Location = New System.Drawing.Point(64, 74)
        Me.RadioButton_bilibili.Name = "RadioButton_bilibili"
        Me.RadioButton_bilibili.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_bilibili.TabIndex = 6
        Me.RadioButton_bilibili.Text = "bilibili"
        Me.RadioButton_bilibili.UseVisualStyleBackColor = True
        '
        'RadioButton_zhihu
        '
        Me.RadioButton_zhihu.AutoSize = True
        Me.RadioButton_zhihu.Location = New System.Drawing.Point(11, 74)
        Me.RadioButton_zhihu.Name = "RadioButton_zhihu"
        Me.RadioButton_zhihu.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_zhihu.TabIndex = 5
        Me.RadioButton_zhihu.Text = "知乎"
        Me.RadioButton_zhihu.UseVisualStyleBackColor = True
        '
        'RadioButton_GooGle
        '
        Me.RadioButton_GooGle.AutoSize = True
        Me.RadioButton_GooGle.Location = New System.Drawing.Point(64, 43)
        Me.RadioButton_GooGle.Name = "RadioButton_GooGle"
        Me.RadioButton_GooGle.Size = New System.Drawing.Size(59, 16)
        Me.RadioButton_GooGle.TabIndex = 3
        Me.RadioButton_GooGle.Text = "Google"
        Me.RadioButton_GooGle.UseVisualStyleBackColor = True
        '
        'RadioButton_Sogou
        '
        Me.RadioButton_Sogou.AutoSize = True
        Me.RadioButton_Sogou.Location = New System.Drawing.Point(64, 21)
        Me.RadioButton_Sogou.Name = "RadioButton_Sogou"
        Me.RadioButton_Sogou.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_Sogou.TabIndex = 2
        Me.RadioButton_Sogou.Text = "搜狗"
        Me.RadioButton_Sogou.UseVisualStyleBackColor = True
        '
        'RadioButton_bing
        '
        Me.RadioButton_bing.AutoSize = True
        Me.RadioButton_bing.Location = New System.Drawing.Point(11, 43)
        Me.RadioButton_bing.Name = "RadioButton_bing"
        Me.RadioButton_bing.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_bing.TabIndex = 1
        Me.RadioButton_bing.Text = "Bing"
        Me.RadioButton_bing.UseVisualStyleBackColor = True
        '
        'RadioButton_baidu
        '
        Me.RadioButton_baidu.AutoSize = True
        Me.RadioButton_baidu.Checked = True
        Me.RadioButton_baidu.Location = New System.Drawing.Point(11, 21)
        Me.RadioButton_baidu.Name = "RadioButton_baidu"
        Me.RadioButton_baidu.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton_baidu.TabIndex = 0
        Me.RadioButton_baidu.TabStop = True
        Me.RadioButton_baidu.Text = "baidu"
        Me.RadioButton_baidu.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 17)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(131, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(61, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "刷新"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "后退"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(110, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(43, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "主页"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(870, 26)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1037, 593)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1053, 632)
        Me.MinimumSize = New System.Drawing.Size(1053, 632)
        Me.Name = "Form1"
        Me.Text = "AuroraGate"
        Me.TopMost = True
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_Sogou As RadioButton
    Friend WithEvents RadioButton_bing As RadioButton
    Friend WithEvents RadioButton_baidu As RadioButton
    Friend WithEvents RadioButton_GooGle As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RadioButton_zhihu As RadioButton
    Friend WithEvents RadioButton_bilibili As RadioButton
    Friend WithEvents RadioButton_weibo As RadioButton
    Friend WithEvents ToolStripSplitButton2 As ToolStripDropDownButton
    Friend WithEvents 报告问题ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 报告新问题ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查看问题列表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于与鸣谢ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 检查更新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 发行说明ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
