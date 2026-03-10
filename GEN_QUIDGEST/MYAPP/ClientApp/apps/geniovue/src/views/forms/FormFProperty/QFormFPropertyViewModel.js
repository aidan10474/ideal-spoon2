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

		/** The hidden foreign keys. */
		this.ValCodcity = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodcity',
			originId: 'ValCodcity',
			area: 'PROPERTY',
			field: 'CODCITY',
			relatedArea: 'CITY',
			isFixed: true,
			description: computed(() => this.Resources.CITY42505),
		}).cloneFrom(values?.ValCodcity))
		this.stopWatchers.push(watch(() => this.ValCodcity.value, (newValue, oldValue) => this.onUpdate('property.codcity', this.ValCodcity, newValue, oldValue)))

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

		/** The remaining form fields. */
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
