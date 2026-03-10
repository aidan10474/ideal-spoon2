using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class F_contactForm : PopupForm
{
	/// <summary>
	/// Title
	/// </summary>
	public LookupControl PropertyTitle => new LookupControl(driver, ContainerLocator, "container-F_CONTACT__PROPERTY__TITLE");
	public SeeMorePage PropertyTitleSeeMorePage => new SeeMorePage(driver, "F_CONTACT", "F_CONTACT__PROPERTY__TITLE");

	/// <summary>
	/// 
	/// </summary>
	public DateInputControl ContactDate => new DateInputControl(driver, ContainerLocator, "#F_CONTACT__CONTACT__DATE");

	/// <summary>
	/// 
	/// </summary>
	public BaseInputControl ContactClient_name => new BaseInputControl(driver, ContainerLocator, "container-F_CONTACT__CONTACT__CLIENT_NAME", "#F_CONTACT__CONTACT__CLIENT_NAME");

	/// <summary>
	/// 
	/// </summary>
	public BaseInputControl ContactEmail_contact => new BaseInputControl(driver, ContainerLocator, "container-F_CONTACT__CONTACT__EMAIL_CONTACT", "#F_CONTACT__CONTACT__EMAIL_CONTACT");

	/// <summary>
	/// 
	/// </summary>
	public BaseInputControl ContactPhone_contact => new BaseInputControl(driver, ContainerLocator, "container-F_CONTACT__CONTACT__PHONE_CONTACT", "#F_CONTACT__CONTACT__PHONE_CONTACT");

	/// <summary>
	/// 
	/// </summary>
	public BaseInputControl ContactDescription => new BaseInputControl(driver, ContainerLocator, "container-F_CONTACT__CONTACT__DESCRIPTION", "#F_CONTACT__CONTACT__DESCRIPTION");

	public F_contactForm(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "F_CONTACT") { }
}
