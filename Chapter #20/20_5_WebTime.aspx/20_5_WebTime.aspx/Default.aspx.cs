using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        timeLabel.Text = String.Format(
            "{0:D2}:{1:D2}:{2:D2}",
            DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second
        );
    }
}