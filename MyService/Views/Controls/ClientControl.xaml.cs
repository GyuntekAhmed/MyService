namespace MyService.Views.Controls;


public partial class ClientControl : ContentView
{
	public event EventHandler<string> OnError;
    public event EventHandler<EventArgs> OnSave;
    public event EventHandler<EventArgs> OnCancel;

    public ClientControl()
	{
		InitializeComponent();
        Photo = new Image();
	}

    public string Name
    {
        get
        {
            return entryName.Text;
        }
        set
        {
            entryName.Text = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return entryPhoneNumber.Text;
        }
        set
        {
            entryPhoneNumber.Text = value;
        }
    }

    public string? RegistrationNumber
    {
        get
        {
            return entryRegistrationNumber.Text;
        }
        set
        {
            entryRegistrationNumber.Text = value;
        }
    }

    public string? Brand
    {
        get
        {
            return entryBrand.Text;
        }
        set
        {
            entryBrand.Text = value;
        }
    }

    public string? Model
    {
        get
        {
            return entryModel.Text;
        }

        set
        {
            entryModel.Text = value;
        }
    }

    public decimal? Assembly
    {
        get
        {
            if (decimal.TryParse(entryAssembly.Text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            entryAssembly.Text = value.ToString();
        }
    }

    public decimal? Disassembly
    {
        get
        {
            if (decimal.TryParse(entryDissembly.Text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            entryDissembly.Text = value.ToString();
        }
    }

    public decimal? Rust
    {
        get
        {
            if (decimal.TryParse(entryRust.Text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            entryRust.Text = value.ToString();
        }
    }

    public decimal? Silicone
    {
        get
        {
            if (decimal.TryParse(entrySilicone.Text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            entrySilicone.Text = value.ToString();
        }
    }

    public decimal Work
    {
        get
        {
            if (decimal.TryParse(entryWork.Text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            entryWork.Text = value.ToString();
        }
    }

    public decimal? Molding
    {
        get
        {
            if (decimal.TryParse(entryMolding.Text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            entryMolding.Text = value.ToString();
        }
    }

    public decimal? Consumables
    {
        get
        {
            if (decimal.TryParse(entryConsumables.Text, out decimal result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            entryConsumables.Text = value.ToString();
        }
    }


    public string? Description
    {
        get
        {
            return entryDescription.Text;
        }
        set
        {
            entryDescription.Text = value;
        }
    }

    public Image Photo { get; set; }

    public ImageSource PhotoSource
    {
        get { return Photo.Source; }
        set { Photo.Source = value; }
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        OnSave?.Invoke(sender, e);
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        OnCancel?.Invoke(sender, e);
    }

    private async void OnSelectPhotoClicked(object sender, EventArgs e)
    {
        var photo = await MediaPicker.PickPhotoAsync();

        if (photo != null)
        {
            Photo.Source = ImageSource.FromStream(() => photo.OpenReadAsync().Result);
        }
    }

}