/* eslint-disable @typescript-eslint/no-unused-vars */
import { computed, reactive, watch } from 'vue'
import _merge from 'lodash-es/merge'

import FormViewModelBase from '@/mixins/formViewModelBase.js'
import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
import modelFieldType from '@quidgest/clientapp/models/fields'

import hardcodedTexts from '@/hardcodedTexts.js'
import netAPI from '@quidgest/clientapp/network'
import qApi from '@/api/genio/quidgestFunctions.js'
import qFunctions from '@/api/genio/projectFunctions.js'
import qProjArrays from '@/api/genio/projectArrays.js'
/* eslint-enable @typescript-eslint/no-unused-vars */

/**
 * Represents a ViewModel class.
 * @extends FormViewModelBase
 */
export default class ViewModel extends FormViewModelBase
{
	/**
	 * Creates a new instance of the ViewModel.
	 * @param {object} vueContext - The Vue context
	 * @param {object} options - The options for the ViewModel
	 * @param {object} values - A ViewModel instance to copy values from
	 */
	// eslint-disable-next-line @typescript-eslint/no-unused-vars
	constructor(vueContext, options, values)
	{
		super(vueContext, options)
		// eslint-disable-next-line @typescript-eslint/no-unused-vars
		const vm = this.vueContext

		// The view model metadata
		_merge(this.modelInfo, {
			name: 'F_PROPERTY',
			area: 'PROPERTY',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_F_property',
				updateFilesTickets: 'UpdateFilesTicketsF_property',
				setFile: 'SetFileF_property'
			}
		})

		/** The primary key. */
		this.ValCodproperty = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodproperty',
			originId: 'ValCodproperty',
			area: 'PROPERTY',
			field: 'CODPROPERTY',
			description: computed(() => this.Resources.PROPERTY43977),
		}).cloneFrom(values?.ValCodproperty))
		this.stopWatchers.push(watch(() => this.ValCodproperty.value, (newValue, oldValue) => this.onUpdate('property.codproperty', this.ValCodproperty, newValue, oldValue)))

		/** The used foreign keys. */
		this.ValCodagent = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodagent',
			originId: 'ValCodagent',
			area: 'PROPERTY',
			field: 'CODAGENT',
			relatedArea: 'BROKER',
			description: computed(() => this.Resources.AGENT00994),
		}).cloneFrom(values?.ValCodagent))
		this.stopWatchers.push(watch(() => this.ValCodagent.value, (newValue, oldValue) => this.onUpdate('property.codagent', this.ValCodagent, newValue, oldValue)))

		this.ValCodcity = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodcity',
			originId: 'ValCodcity',
			area: 'PROPERTY',
			field: 'CODCITY',
			relatedArea: 'CITY',
			description: computed(() => this.Resources.CITY42505),
		}).cloneFrom(values?.ValCodcity))
		this.stopWatchers.push(watch(() => this.ValCodcity.value, (newValue, oldValue) => this.onUpdate('property.codcity', this.ValCodcity, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValId = reactive(new modelFieldType.Number({
			id: 'ValId',
			originId: 'ValId',
			area: 'PROPERTY',
			field: 'ID',
			maxDigits: 10,
			decimalDigits: 0,
			description: computed(() => this.Resources.ID48520),
		}).cloneFrom(values?.ValId))
		this.stopWatchers.push(watch(() => this.ValId.value, (newValue, oldValue) => this.onUpdate('property.id', this.ValId, newValue, oldValue)))

		this.ValMain_photo = reactive(new modelFieldType.Image({
			id: 'ValMain_photo',
			originId: 'ValMain_photo',
			area: 'PROPERTY',
			field: 'MAIN_PHOTO',
			description: computed(() => this.Resources.MAIN_PHOTO18723),
		}).cloneFrom(values?.ValMain_photo))
		this.stopWatchers.push(watch(() => this.ValMain_photo.value, (newValue, oldValue) => this.onUpdate('property.main_photo', this.ValMain_photo, newValue, oldValue)))

		this.ValTitle = reactive(new modelFieldType.String({
			id: 'ValTitle',
			originId: 'ValTitle',
			area: 'PROPERTY',
			field: 'TITLE',
			maxLength: 80,
			description: computed(() => this.Resources.TITLE21885),
		}).cloneFrom(values?.ValTitle))
		this.stopWatchers.push(watch(() => this.ValTitle.value, (newValue, oldValue) => this.onUpdate('property.title', this.ValTitle, newValue, oldValue)))

		this.ValPrice = reactive(new modelFieldType.Number({
			id: 'ValPrice',
			originId: 'ValPrice',
			area: 'PROPERTY',
			field: 'PRICE',
			maxDigits: 10,
			decimalDigits: 4,
			description: computed(() => this.Resources.PRICE_0000000000_0058065),
		}).cloneFrom(values?.ValPrice))
		this.stopWatchers.push(watch(() => this.ValPrice.value, (newValue, oldValue) => this.onUpdate('property.price', this.ValPrice, newValue, oldValue)))

		this.ValDescription = reactive(new modelFieldType.String({
			id: 'ValDescription',
			originId: 'ValDescription',
			area: 'PROPERTY',
			field: 'DESCRIPTION',
			maxLength: 50,
			description: computed(() => this.Resources.DESCRIPTION07383),
		}).cloneFrom(values?.ValDescription))
		this.stopWatchers.push(watch(() => this.ValDescription.value, (newValue, oldValue) => this.onUpdate('property.description', this.ValDescription, newValue, oldValue)))

		this.TableBrokerName = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableBrokerName',
			originId: 'ValName',
			area: 'BROKER',
			field: 'NAME',
			maxLength: 50,
			description: computed(() => this.Resources.NAME31974),
			ignoreFldSubmit: true,
		}).cloneFrom(values?.TableBrokerName))
		this.stopWatchers.push(watch(() => this.TableBrokerName.value, (newValue, oldValue) => this.onUpdate('broker.name', this.TableBrokerName, newValue, oldValue)))

		this.BrokerValEmail = reactive(new modelFieldType.String({
			id: 'BrokerValEmail',
			originId: 'ValEmail',
			area: 'BROKER',
			field: 'EMAIL',
			maxLength: 256,
			isFixed: true,
			description: computed(() => this.Resources.EMAIL25170),
		}).cloneFrom(values?.BrokerValEmail))
		this.stopWatchers.push(watch(() => this.BrokerValEmail.value, (newValue, oldValue) => this.onUpdate('broker.email', this.BrokerValEmail, newValue, oldValue)))

		this.BrokerValPhoto = reactive(new modelFieldType.Image({
			id: 'BrokerValPhoto',
			originId: 'ValPhoto',
			area: 'BROKER',
			field: 'PHOTO',
			isFixed: true,
			description: computed(() => this.Resources.PHOTO51874),
		}).cloneFrom(values?.BrokerValPhoto))
		this.stopWatchers.push(watch(() => this.BrokerValPhoto.value, (newValue, oldValue) => this.onUpdate('broker.photo', this.BrokerValPhoto, newValue, oldValue)))

		this.TableCityCity = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableCityCity',
			originId: 'ValCity',
			area: 'CITY',
			field: 'CITY',
			maxLength: 50,
			description: computed(() => this.Resources.CITY42505),
			ignoreFldSubmit: true,
		}).cloneFrom(values?.TableCityCity))
		this.stopWatchers.push(watch(() => this.TableCityCity.value, (newValue, oldValue) => this.onUpdate('city.city', this.TableCityCity, newValue, oldValue)))

		this.CityCountryValCountry = reactive(new modelFieldType.String({
			id: 'CityCountryValCountry',
			originId: 'ValCountry',
			area: 'COUNTRY',
			field: 'COUNTRY',
			maxLength: 50,
			isFixed: true,
			description: computed(() => this.Resources.COUNTRY64133),
		}).cloneFrom(values?.CityCountryValCountry))
		this.stopWatchers.push(watch(() => this.CityCountryValCountry.value, (newValue, oldValue) => this.onUpdate('country.country', this.CityCountryValCountry, newValue, oldValue)))

		this.ValDate_construction = reactive(new modelFieldType.Date({
			id: 'ValDate_construction',
			originId: 'ValDate_construction',
			area: 'PROPERTY',
			field: 'DATECONSTRUCTION',
			description: computed(() => this.Resources.DATE18475),
		}).cloneFrom(values?.ValDate_construction))
		this.stopWatchers.push(watch(() => this.ValDate_construction.value, (newValue, oldValue) => this.onUpdate('property.date_construction', this.ValDate_construction, newValue, oldValue)))

		this.ValBuildingage = reactive(new modelFieldType.Number({
			id: 'ValBuildingage',
			originId: 'ValBuildingage',
			area: 'PROPERTY',
			field: 'BUILDINGAGE',
			maxDigits: 10,
			decimalDigits: 0,
			isFixed: true,
			valueFormula: {
				stopRecalcCondition() { return false },
				// eslint-disable-next-line @typescript-eslint/no-unused-vars
				fnFormula(params)
				{
					// Formula: Year([Today]) - Year([PROPERTY->DATECONSTRUCTION])
					return qApi.Year(qApi.Today())-qApi.Year(this.ValDate_construction.value)
				},
				dependencyEvents: ['fieldChange:property.date_construction'],
				isServerRecalc: false,
				isEmpty: qApi.emptyN,
			},
			description: computed(() => this.Resources.BUILDING_AGE27311),
		}).cloneFrom(values?.ValBuildingage))
		this.stopWatchers.push(watch(() => this.ValBuildingage.value, (newValue, oldValue) => this.onUpdate('property.buildingage', this.ValBuildingage, newValue, oldValue)))

		this.ValBuildingtype = reactive(new modelFieldType.String({
			id: 'ValBuildingtype',
			originId: 'ValBuildingtype',
			area: 'PROPERTY',
			field: 'BUILDINGTYPE',
			maxLength: 1,
			arrayOptions: computed(() => new qProjArrays.QArrayBuildingtype(vm.$getResource).elements),
			description: computed(() => this.Resources.BUILDING_TYPE57152),
		}).cloneFrom(values?.ValBuildingtype))
		this.stopWatchers.push(watch(() => this.ValBuildingtype.value, (newValue, oldValue) => this.onUpdate('property.buildingtype', this.ValBuildingtype, newValue, oldValue)))

		this.ValBathroom_number = reactive(new modelFieldType.String({
			id: 'ValBathroom_number',
			originId: 'ValBathroom_number',
			area: 'PROPERTY',
			field: 'BATHROOMSNUMBER',
			maxLength: 50,
			description: computed(() => this.Resources.BATHROOMS54249),
		}).cloneFrom(values?.ValBathroom_number))
		this.stopWatchers.push(watch(() => this.ValBathroom_number.value, (newValue, oldValue) => this.onUpdate('property.bathroom_number', this.ValBathroom_number, newValue, oldValue)))

		this.ValTypology = reactive(new modelFieldType.Number({
			id: 'ValTypology',
			originId: 'ValTypology',
			area: 'PROPERTY',
			field: 'TYPOLOGY',
			maxDigits: 1,
			decimalDigits: 0,
			arrayOptions: computed(() => new qProjArrays.QArrayTypology(vm.$getResource).elements),
			description: computed(() => this.Resources.TYPOLOGY11991),
		}).cloneFrom(values?.ValTypology))
		this.stopWatchers.push(watch(() => this.ValTypology.value, (newValue, oldValue) => this.onUpdate('property.typology', this.ValTypology, newValue, oldValue)))

		this.ValSize = reactive(new modelFieldType.String({
			id: 'ValSize',
			originId: 'ValSize',
			area: 'PROPERTY',
			field: 'SIZE',
			maxLength: 50,
			description: computed(() => this.Resources.SIZE10299),
		}).cloneFrom(values?.ValSize))
		this.stopWatchers.push(watch(() => this.ValSize.value, (newValue, oldValue) => this.onUpdate('property.size', this.ValSize, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFPropertyViewModel instance.
	 * @returns {QFormFPropertyViewModel} A new instance of QFormFPropertyViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodproperty'

	get QPrimaryKey() { return this.ValCodproperty.value }
	set QPrimaryKey(value) { this.ValCodproperty.updateValue(value) }
}
