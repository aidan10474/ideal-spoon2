using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class F_brokeForm : Form
{
	/// <summary>
	/// Photo
	/// </summary>
	public BaseInputControl BrokerPhoto => new BaseInputControl(driver, ContainerLocator, "container-F_BROKE__BROKER__PHOTO", "#F_BROKE__BROKER__PHOTO");

	/// <summary>
	/// Name
	/// </summary>
	public BaseInputControl BrokerName => new BaseInputControl(driver, ContainerLocator, "container-F_BROKE__BROKER__NAME", "#F_BROKE__BROKER__NAME");

	/// <summary>
	/// Birthdate
	/// </summary>
	public DateInputControl BrokerBirthdate => new DateInputControl(driver, ContainerLocator, "#F_BROKE__BROKER__BIRTHDATE");

	/// <summary>
	/// Email
	/// </summary>
	public BaseInputControl BrokerEmail => new BaseInputControl(driver, ContainerLocator, "container-F_BROKE__BROKER__EMAIL", "#F_BROKE__BROKER__EMAIL");

	/// <summary>
	/// Phone number
	/// </summary>
	public BaseInputControl BrokerPhone_number => new BaseInputControl(driver, ContainerLocator, "container-F_BROKE__BROKER__PHONE_NUMBER", "#F_BROKE__BROKER__PHONE_NUMBER");

	public F_brokeForm(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "F_BROKE", containerLocator: containerLocator) { }
}
