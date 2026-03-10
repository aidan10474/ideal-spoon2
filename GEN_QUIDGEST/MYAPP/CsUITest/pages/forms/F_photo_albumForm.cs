using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class F_photo_albumForm : Form
{
	/// <summary>
	/// 
	/// </summary>
	public BaseInputControl Photo_albumPhoto => new BaseInputControl(driver, ContainerLocator, "container-F_PHOTO_ALBUM__PHOTO_ALBUM__PHOTO", "#F_PHOTO_ALBUM__PHOTO_ALBUM__PHOTO");

	/// <summary>
	/// Title
	/// </summary>
	public LookupControl PropertyTitle => new LookupControl(driver, ContainerLocator, "container-F_PHOTO_ALBUM__PROPERTY__TITLE");
	public SeeMorePage PropertyTitleSeeMorePage => new SeeMorePage(driver, "F_PHOTO_ALBUM", "F_PHOTO_ALBUM__PROPERTY__TITLE");

	/// <summary>
	/// 
	/// </summary>
	public BaseInputControl Photo_albumTitle => new BaseInputControl(driver, ContainerLocator, "container-F_PHOTO_ALBUM__PHOTO_ALBUM__TITLE", "#F_PHOTO_ALBUM__PHOTO_ALBUM__TITLE");

	public F_photo_albumForm(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "F_PHOTO_ALBUM", containerLocator: containerLocator) { }
}
