using HabitsReelPlus.ViewViewModels.Login.ForgotPassword;

namespace HabitsReelPlus.ViewViewModels.Login;

public partial class ForgotPasswordView : ContentPage
{
	public ForgotPasswordView()
	{
		InitializeComponent();
		BindingContext = new ForgotPasswordViewModel();
	}
}