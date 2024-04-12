Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStripStatusLabel1.Text = "正在加载"

        Dim uriText As String = TextBox1.Text
        Dim uriResult As Uri

        If Uri.TryCreate(uriText, UriKind.Absolute, uriResult) Then
            WebBrowser1.Url = uriResult
            ToolStripStatusLabel1.Text = "加载完成"

        ElseIf RadioButton_baidu.Checked Then
            ' 若文本框内的文本不是有效URL,则在选定的搜索引擎搜索
            WebBrowser1.Url = New Uri("https://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd=" + uriText + "&fenlei=256&oq=1122%2526lt%253B%2526lt%253B&rsv_pq=a17d8dae00004aa2&rsv_t=4848i9zGQhOak0CA7X0%2BqI9SLLfjIq7hmNmhqov2MNGy4PqZo6Ip0IEIhNA&rqlang=cn&rsv_enter=0&rsv_dl=tb&rsv_btype=t&prefixsug=1122%2526lt%253B%2526lt%253B&rsp=5")
            ToolStripStatusLabel1.Text = "加载完成"

        ElseIf RadioButton_bing.Checked Then
            WebBrowser1.Url = New Uri("http://cn.bing.com/search?q=" + uriText + "&go=&form=QBLH&qs=n&sk=")
            ToolStripStatusLabel1.Text = "加载完成"

        ElseIf RadioButton_GooGle.Checked Then
            WebBrowser1.Url = New Uri("https://www.google.com/search?q=" + uriText)
            ToolStripStatusLabel1.Text = "加载完成"

        ElseIf RadioButton_Sogou.Checked Then
            WebBrowser1.Url = New Uri("https://www.sogou.com/web?query=" + uriText)
            ToolStripStatusLabel1.Text = "加载完成"

        ElseIf RadioButton_zhihu.Checked Then
            WebBrowser1.Url = New Uri("https://www.zhihu.com/search?type=content&q=" + uriText)
            ToolStripStatusLabel1.Text = "加载完成"

        ElseIf RadioButton_bilibili.Checked Then
            WebBrowser1.Url = New Uri("https://search.bilibili.com/all?keyword=" + uriText)
            ToolStripStatusLabel1.Text = "加载完成"

        ElseIf RadioButton_weibo.Checked Then
            WebBrowser1.Url = New Uri("https://s.weibo.com/weibo?q=" + uriText)
            ToolStripStatusLabel1.Text = "加载完成"
        End If


        If Not IsNothing(WebBrowser1.Url) Then
            Dim myUri As Uri = WebBrowser1.Url
            Dim myUriAsString As String = myUri.ToString()
            TextBox1.Text = myUriAsString
        End If
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        If WebBrowser1.Url IsNot Nothing Then
            Dim currentUri As Uri = WebBrowser1.Url
            Dim domain As String = currentUri.Host
            ' 输出或使用域名
            ToolStripStatusLabel2.Text = ("连接到: " & domain)
        Else
            ToolStripStatusLabel2.Text = ("-")
        End If
    End Sub


    Private Sub WebBrowser1_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WebBrowser1.NewWindow
        ' 取消默认的新窗口打开行为
        e.Cancel = True

        ' 获取要导航到的URL
        ' 注意：这里的方法可能需要根据实际情况调整
        Dim url As String = WebBrowser1.StatusText

        ' 在当前WebBrowser控件中导航到新URL
        WebBrowser1.Navigate(url)

        If WebBrowser1.Url IsNot Nothing Then
            Dim currentUri As Uri = WebBrowser1.Url
            Dim domain As String = currentUri.Host
            ' 输出或使用域名
            ToolStripStatusLabel2.Text = ("当前站点: " & domain)
        Else
            ToolStripStatusLabel2.Text = ("未连接")
        End If
    End Sub
    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        ' 取消脚本错误提示
        WebBrowser1.ScriptErrorsSuppressed = True
        ' 检查是否成功加载了文档
        If e.Url.AbsolutePath <> "" Then
            ' 获取网页标题
            Dim docTitle As String = WebBrowser1.DocumentTitle
            ' 显示标题
            TextBox2.Text = docTitle
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ' 注册WebBrowserError事件处理程序
        AddHandler WebBrowser1.Document.Window.Error, AddressOf WebBrowser_Error

        If WebBrowser1.Url IsNot Nothing Then
            Dim currentUri As Uri = WebBrowser1.Url
            Dim domain As String = currentUri.Host
            ' 输出或使用域名
            ToolStripStatusLabel2.Text = ("当前站点: " & domain)
        Else
            ToolStripStatusLabel2.Text = ("未连接")
        End If
        Dim myUri As Uri = WebBrowser1.Url
        Dim myUriAsString As String = myUri.ToString()
        TextBox1.Text = myUriAsString

        ' 检查是否成功加载了文档
        If e.Url.AbsolutePath <> "" Then
            ' 获取网页标题
            Dim docTitle As String = WebBrowser1.DocumentTitle
            ' 显示标题
            TextBox2.Text = docTitle
        End If
    End Sub

    Private Sub WebBrowser_Error(sender As Object, e As HtmlElementErrorEventArgs)
        ' 在这里进行自定义错误处理
        'MessageBox.Show($"JavaScript错误: {e.Description}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ' 可以选择取消默认行为，如下所示
        e.Handled = True
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        ' 检查用户是否按下了回车键
        If e.KeyCode = Keys.Enter Then
            ' 取消回车键的默认行为（防止在文本框中换行）
            e.SuppressKeyPress = True

            ' 模拟用户点击Button1按钮
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Refresh()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ToolStripStatusLabel1.Text = "正在加载"

        If RadioButton_baidu.Checked Then
            WebBrowser1.Url = New Uri("https://www.baidu.com/")
            ToolStripStatusLabel1.Text = "加载完成"
        ElseIf RadioButton_bing.Checked Then
            WebBrowser1.Url = New Uri("http://cn.bing.com/")
        ElseIf RadioButton_GooGle.Checked Then
            WebBrowser1.Url = New Uri("https://www.google.com/")
            ToolStripStatusLabel1.Text = "加载完成"
        End If
        If Not IsNothing(WebBrowser1.Url) Then
            Dim myUri As Uri = WebBrowser1.Url
            Dim myUriAsString As String = myUri.ToString()
            TextBox1.Text = myUriAsString
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 检查是否可以返回
        If WebBrowser1.CanGoBack Then
            ' 执行返回操作
            WebBrowser1.GoBack()
        Else
            ' 如果不能返回，可以显示一个消息
            MessageBox.Show("无法返回，没有更多历史记录。")
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub 报告新问题ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 报告新问题ToolStripMenuItem.Click
        Process.Start("https://github.com/Tydecent/AuroraGate/issues/new")
    End Sub

    Private Sub 查看问题列表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查看问题列表ToolStripMenuItem.Click
        Process.Start("https://github.com/Tydecent/AuroraGate/issues")
    End Sub

    Private Sub 关于与鸣谢ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于与鸣谢ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub 发行说明ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 发行说明ToolStripMenuItem1.Click
        Process.Start("https://github.com/Tydecent/AuroraGate/releases/tag/v0.1.1-vb")
    End Sub
End Class
