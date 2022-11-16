namespace Jul.Services;

public class ControlsService
{
    public async Task<bool> ConfirmWindow(string content, string title = "warning")
    {
        var result = MessageBox.Show(content, title, MessageBoxButtons.OKCancel);
        return await Task.FromResult(result == DialogResult.OK);
    }
}