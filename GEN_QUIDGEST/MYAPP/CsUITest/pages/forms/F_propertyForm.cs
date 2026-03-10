using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class F_propertyForm : Form
{
	/// <summary>
	/// MAIN INFO
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp01 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP01-container");

	/// <summary>
	/// Main Photo
	/// </summary>
	public BaseInputControl PropertyMain_photo => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__MAIN_PHOTO", "#F_PROPERTY__PROPERTY__MAIN_PHOTO");

	/// <summary>
	/// Title
	/// </summary>
	public BaseInputControl PropertyTitle => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__TITLE", "#F_PROPERTY__PROPERTY__TITLE");

	/// <summary>
	/// Price 0000000000,00
	/// </summary>
	public BaseInputControl PropertyPrice => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__PRICE", "#F_PROPERTY__PROPERTY__PRICE");

	/// <summary>
	/// Description
	/// </summary>
	public BaseInputControl PropertyDescription => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__DESCRIPTION", "#F_PROPERTY__PROPERTY__DESCRIPTION");

	/// <summary>
	/// brokers information
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp04 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP04-container");

	/// <summary>
	/// Broker.name
	/// </summary>
	public LookupControl BrokerName => new LookupControl(driver, ContainerLocator, "container-F_PROPERTY__BROKER__NAME");
	public SeeMorePage BrokerNameSeeMorePage => new SeeMorePage(driver, "F_PROPERTY", "F_PROPERTY__BROKER__NAME");

	/// <summary>
	/// Email
	/// </summary>
	public IWebElement BrokerEmail => throw new NotImplementedException();

	/// <summary>
	/// Photo
	/// </summary>
	public IWebElement BrokerPhoto => throw new NotImplementedException();

	/// <summary>
	/// Localization
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp03 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP03-container");

	/// <summary>
	/// City
	/// </summary>
	public LookupControl CityCity => new LookupControl(driver, ContainerLocator, "container-F_PROPERTY__CITY__CITY");
	public SeeMorePage CityCitySeeMorePage => new SeeMorePage(driver, "F_PROPERTY", "F_PROPERTY__CITY__CITY");

	/// <summary>
	/// Country
	/// </summary>
	public IWebElement CountryCountry => throw new NotImplementedException();

	/// <summary>
	/// details
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp02 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP02-container");

	/// <summary>
	/// Date
	/// </summary>
	public DateInputControl PropertyDateconstruction => new DateInputControl(driver, ContainerLocator, "#F_PROPERTY__PROPERTY__DATECONSTRUCTION");

	/// <summary>
	/// Size
	/// </summary>
	public BaseInputControl PropertySize => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__SIZE", "#F_PROPERTY__PROPERTY__SIZE");

	/// <summary>
	/// Bathrooms
	/// </summary>
	public BaseInputControl PropertyBathroomsnumber => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__BATHROOMSNUMBER", "#F_PROPERTY__PROPERTY__BATHROOMSNUMBER");

	public F_propertyForm(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "F_PROPERTY", containerLocator: containerLocator) { }
}
