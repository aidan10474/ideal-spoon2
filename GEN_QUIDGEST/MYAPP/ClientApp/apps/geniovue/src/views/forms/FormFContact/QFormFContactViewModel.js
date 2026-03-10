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
			name: 'F_CONTACT',
			area: 'CONTACT',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_F_contact',
				updateFilesTickets: 'UpdateFilesTicketsF_contact',
				setFile: 'SetFileF_contact'
			}
		})

		/** The primary key. */
		this.ValCodcontact = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodcontact',
			originId: 'ValCodcontact',
			area: 'CONTACT',
			field: 'CODCONTACT',
			description: '',
		}).cloneFrom(values?.ValCodcontact))
		this.stopWatchers.push(watch(() => this.ValCodcontact.value, (newValue, oldValue) => this.onUpdate('contact.codcontact', this.ValCodcontact, newValue, oldValue)))

		/** The used foreign keys. */
		this.ValCodproperty = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodproperty',
			originId: 'ValCodproperty',
			area: 'CONTACT',
			field: 'CODPROPERTY',
			relatedArea: 'PROPERTY',
			description: '',
		}).cloneFrom(values?.ValCodproperty))
		this.stopWatchers.push(watch(() => this.ValCodproperty.value, (newValue, oldValue) => this.onUpdate('contact.codproperty', this.ValCodproperty, newValue, oldValue)))

		/** The remaining form fields. */
		this.TablePropertyTitle = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TablePropertyTitle',
			originId: 'ValTitle',
			area: 'PROPERTY',
			field: 'TITLE',
			maxLength: 80,
			description: computed(() => this.Resources.TITLE21885),
			ignoreFldSubmit: true,
		}).cloneFrom(values?.TablePropertyTitle))
		this.stopWatchers.push(watch(() => this.TablePropertyTitle.value, (newValue, oldValue) => this.onUpdate('property.title', this.TablePropertyTitle, newValue, oldValue)))

		this.ValDate = reactive(new modelFieldType.Date({
			id: 'ValDate',
			originId: 'ValDate',
			area: 'CONTACT',
			field: 'DATE',
			description: '',
		}).cloneFrom(values?.ValDate))
		this.stopWatchers.push(watch(() => this.ValDate.value, (newValue, oldValue) => this.onUpdate('contact.date', this.ValDate, newValue, oldValue)))

		this.ValClient_name = reactive(new modelFieldType.String({
			id: 'ValClient_name',
			originId: 'ValClient_name',
			area: 'CONTACT',
			field: 'CLIENT_NAME',
			maxLength: 50,
			description: '',
		}).cloneFrom(values?.ValClient_name))
		this.stopWatchers.push(watch(() => this.ValClient_name.value, (newValue, oldValue) => this.onUpdate('contact.client_name', this.ValClient_name, newValue, oldValue)))

		this.ValEmail_contact = reactive(new modelFieldType.String({
			id: 'ValEmail_contact',
			originId: 'ValEmail_contact',
			area: 'CONTACT',
			field: 'EMAIL_CONTACT',
			maxLength: 50,
			description: '',
		}).cloneFrom(values?.ValEmail_contact))
		this.stopWatchers.push(watch(() => this.ValEmail_contact.value, (newValue, oldValue) => this.onUpdate('contact.email_contact', this.ValEmail_contact, newValue, oldValue)))

		this.ValPhone_contact = reactive(new modelFieldType.Number({
			id: 'ValPhone_contact',
			originId: 'ValPhone_contact',
			area: 'CONTACT',
			field: 'PHONE_CONTACT',
			maxDigits: 12,
			decimalDigits: 2,
			description: '',
		}).cloneFrom(values?.ValPhone_contact))
		this.stopWatchers.push(watch(() => this.ValPhone_contact.value, (newValue, oldValue) => this.onUpdate('contact.phone_contact', this.ValPhone_contact, newValue, oldValue)))

		this.ValDescription = reactive(new modelFieldType.String({
			id: 'ValDescription',
			originId: 'ValDescription',
			area: 'CONTACT',
			field: 'DESCRIPTION',
			maxLength: 50,
			description: '',
		}).cloneFrom(values?.ValDescription))
		this.stopWatchers.push(watch(() => this.ValDescription.value, (newValue, oldValue) => this.onUpdate('contact.description', this.ValDescription, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFContactViewModel instance.
	 * @returns {QFormFContactViewModel} A new instance of QFormFContactViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodcontact'

	get QPrimaryKey() { return this.ValCodcontact.value }
	set QPrimaryKey(value) { this.ValCodcontact.updateValue(value) }
}
