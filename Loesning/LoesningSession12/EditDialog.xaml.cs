using CommunityToolkit.Maui.Views;
using LoesningSession7.ViewModel;

namespace LoesningSession7;

public partial class EditDialog : Popup
{
    internal EditDialog(Bil bilTilRedigering)
    {
        InitializeComponent();
        BilTilRedigering = bilTilRedigering;
    }

    private Bil bilTilRedigering;
    internal Bil BilTilRedigering
    {
        get { return bilTilRedigering; }
        set
        {
            bilTilRedigering = value;
            ModelEntry.BindingContext = bilTilRedigering;
            HkEntry.BindingContext = bilTilRedigering;
            ElbilChk.BindingContext = bilTilRedigering;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Close();
    }
}