using PostmanCloneLibrary;
using System.Linq.Expressions;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{

    private readonly IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApiButton_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        systemStatus.Text = "";


        //Validate API URL
        if (api.IsValidUrl(apiText.Text)== false) 
        {
            systemStatus.Text = "Invalid URL";
            return;
        }
        try
        {
           resultsText.Text = await api.CallApiAsync(apiText.Text);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {

            resultsText.Text = "An Error Occured" + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }
}
