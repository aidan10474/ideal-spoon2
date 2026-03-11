<template>
	<teleport
		v-if="menuModalIsReady"
		:to="`#${uiContainersId.body}`"
		:disabled="!menuInfo.isPopup">
		<form
			class="form-horizontal"
			@submit.prevent>
			<q-row-container>
				<q-table
					v-bind="controls.menu"
					v-on="controls.menu.handlers">
					<template #header>
						<q-table-config
							:table-ctrl="controls.menu"
							v-on="controls.menu.handlers" />
					</template>
					<!-- USE /[MANUAL TRA CUSTOM_TABLE TRA_Menu_21]/ -->
				</q-table>
			</q-row-container>
		</form>
	</teleport>

	<teleport
		v-if="menuModalIsReady && hasButtons"
		:to="`#${uiContainersId.footer}`"
		:disabled="!menuInfo.isPopup">
		<q-row-container>
			<div id="footer-action-btns">
				<template
					v-for="btn in menuButtons"
					:key="btn.id">
					<q-button
						v-if="btn.isVisible"
						:id="btn.id"
						:label="btn.text"
						:variant="btn.variant"
						:disabled="btn.disabled"
						:icon-pos="btn.iconPos"
						:class="btn.classes"
						@click="btn.action">
						<q-icon
							v-if="btn.icon"
							v-bind="btn.icon" />
					</q-button>
				</template>
			</div>
		</q-row-container>
	</teleport>
</template>

<script>
	/* eslint-disable @typescript-eslint/no-unused-vars */
	import asyncProcM from '@quidgest/clientapp/composables/async'
	import qEnums from '@quidgest/clientapp/constants/enums'
	import netAPI from '@quidgest/clientapp/network'
	import openQSign from '@quidgest/clientapp/plugins/qSign'
	import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
	import { computed, readonly } from 'vue'

	import MenuHandlers from '@/mixins/menuHandlers.js'
	import controlClass from '@/mixins/fieldControl.js'
	import listFunctions from '@/mixins/listFunctions.js'
	import listColumnTypes from '@/mixins/listColumnTypes.js'
	import { resetProgressBar, setProgressBar } from '@/utils/layout.js'

	import { loadResources } from '@/plugins/i18n.js'

	import hardcodedTexts from '@/hardcodedTexts'
	import qApi from '@/api/genio/quidgestFunctions.js'
	import qFunctions from '@/api/genio/projectFunctions.js'
	import qProjArrays from '@/api/genio/projectArrays.js'
	/* eslint-enable @typescript-eslint/no-unused-vars */

	import MenuViewModel from './QMenuTRA_21ViewModel.js'

	const requiredTextResources = ['QMenuTRA_21', 'hardcoded', 'messages']

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL TRA FORM_INCLUDEJS TRA_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

	export default {
		name: 'QMenuTra21',

		mixins: [
			MenuHandlers
		],

		inheritAttrs: false,

		props: {
			/**
			 * Whether or not the menu is used as a homepage.
			 */
			isHomePage: {
				type: Boolean,
				default: false
			}
		},

		expose: [
			'navigationId',
			'onBeforeRouteLeave',
			'updateMenuNavigation'
		],

		data()
		{
			// eslint-disable-next-line
			const vm = this
			return {
				componentOnLoadProc: asyncProcM.getProcListMonitor('QMenuTRA_21', false),

				interfaceMetadata: {
					id: 'QMenuTRA_21', // Used for resources
					requiredTextResources
				},

				menuInfo: {
					id: '21',
					isMenuList: true,
					designation: computed(() => this.Resources.PROPERTIES34868),
					acronym: 'TRA_21',
					name: 'PROPERTY',
					route: 'menu-TRA_21',
					order: '21',
					controller: 'PROPERTY',
					action: 'TRA_Menu_21',
					isPopup: false
				},

				model: new MenuViewModel(this),

				controls: {
					menu: new controlClass.TableListControl({
						fnHydrateViewModel: (data) => vm.model.hydrate(data),
						id: 'TRA_Menu_21',
						controller: 'PROPERTY',
						action: 'TRA_Menu_21',
						hasDependencies: false,
						isInCollapsible: false,
						tableModeClasses: [
							'q-table--full-height',
							'page-full-height'
						],
						columnsOriginal: [
							new listColumnTypes.TextColumn({
								order: 1,
								name: 'Broker.ValName',
								area: 'BROKER',
								field: 'NAME',
								label: computed(() => this.Resources.NAME31974),
								dataLength: 50,
								scrollData: 30,
								export: 1,
								pkColumn: 'ValCodbroker',
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.TextColumn({
								order: 2,
								name: 'ValSize',
								area: 'PROPERTY',
								field: 'SIZE',
								label: computed(() => this.Resources.SIZE10299),
								dataLength: 50,
								scrollData: 30,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.ImageColumn({
								order: 3,
								name: 'ValMain_photo',
								area: 'PROPERTY',
								field: 'MAIN_PHOTO',
								label: computed(() => this.Resources.MAIN_PHOTO18723),
								dataTitle: computed(() => genericFunctions.formatString(vm.Resources.IMAGEM_UTILIZADA_PAR58591, vm.Resources.MAIN_PHOTO18723)),
								scrollData: 3,
								sortable: false,
								searchable: false,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.TextColumn({
								order: 4,
								name: 'ValDescription',
								area: 'PROPERTY',
								field: 'DESCRIPTION',
								label: computed(() => this.Resources.DESCRIPTION07383),
								dataLength: 50,
								scrollData: 30,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.CurrencyColumn({
								order: 5,
								name: 'ValPrice',
								area: 'PROPERTY',
								field: 'PRICE',
								label: computed(() => this.Resources.PRICE_0000000000_0058065),
								scrollData: 15,
								maxDigits: 10,
								decimalPlaces: 4,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.DateColumn({
								order: 6,
								name: 'ValDate_construction',
								area: 'PROPERTY',
								field: 'DATE_CONSTRUCTION',
								label: computed(() => this.Resources.DATE18475),
								scrollData: 8,
								dateTimeType: 'date',
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.ArrayColumn({
								order: 7,
								name: 'ValTypology',
								area: 'PROPERTY',
								field: 'TYPOLOGY',
								label: computed(() => this.Resources.TYPOLOGY11991),
								scrollData: 1,
								maxDigits: 1,
								decimalPlaces: 0,
								export: 1,
								array: computed(() => new qProjArrays.QArrayTypology(vm.$getResource).elements),
								arrayType: qProjArrays.QArrayTypology.type,
								arrayDisplayMode: 'D',
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.NumericColumn({
								order: 8,
								name: 'ValBuildingage',
								area: 'PROPERTY',
								field: 'BUILDINGAGE',
								label: computed(() => this.Resources.BUILDING_AGE27311),
								scrollData: 10,
								maxDigits: 10,
								decimalPlaces: 0,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.NumericColumn({
								order: 9,
								name: 'ValId',
								area: 'PROPERTY',
								field: 'ID',
								label: computed(() => this.Resources.ID48520),
								scrollData: 10,
								maxDigits: 10,
								decimalPlaces: 0,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.ArrayColumn({
								order: 10,
								name: 'ValBuildingtype',
								area: 'PROPERTY',
								field: 'BUILDINGTYPE',
								label: computed(() => this.Resources.BUILDING_TYPE57152),
								dataLength: 1,
								scrollData: 1,
								export: 1,
								array: computed(() => new qProjArrays.QArrayBuildingtype(vm.$getResource).elements),
								arrayType: qProjArrays.QArrayBuildingtype.type,
								arrayDisplayMode: 'D',
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.TextColumn({
								order: 11,
								name: 'ValBathroom_number',
								area: 'PROPERTY',
								field: 'BATHROOM_NUMBER',
								label: computed(() => this.Resources.BATHROOMS54249),
								dataLength: 50,
								scrollData: 30,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
							new listColumnTypes.TextColumn({
								order: 12,
								name: 'ValTitle',
								area: 'PROPERTY',
								field: 'TITLE',
								label: computed(() => this.Resources.TITLE21885),
								dataLength: 80,
								scrollData: 30,
								export: 1,
							}, computed(() => vm.model), computed(() => vm.internalEvents)),
						],
						config: {
							name: 'TRA_Menu_21',
							serverMode: true,
							pkColumn: 'ValCodproperty',
							tableAlias: 'PROPERTY',
							tableNamePlural: computed(() => this.Resources.PROPERTIES34868),
							viewManagement: '',
							showLimitsInfo: true,
							tableTitle: computed(() => this.Resources.PROPERTIES34868),
							showAlternatePagination: true,
							permissions: {
							},
							searchBarConfig: {
								visibility: true
							},
							allowColumnFilters: true,
							allowColumnSort: true,
							crudActions: [
								{
									id: 'show',
									name: 'show',
									title: computed(() => this.Resources.CONSULTAR57388),
									icon: {
										icon: 'view'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_PROPERTY',
										mode: 'SHOW',
										isControlled: true
									}
								},
								{
									id: 'edit',
									name: 'edit',
									title: computed(() => this.Resources.EDITAR11616),
									icon: {
										icon: 'pencil'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_PROPERTY',
										mode: 'EDIT',
										isControlled: true
									}
								},
								{
									id: 'duplicate',
									name: 'duplicate',
									title: computed(() => this.Resources.DUPLICAR09748),
									icon: {
										icon: 'duplicate'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_PROPERTY',
										mode: 'DUPLICATE',
										isControlled: true
									}
								},
								{
									id: 'delete',
									name: 'delete',
									title: computed(() => this.Resources.ELIMINAR21155),
									icon: {
										icon: 'delete'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_PROPERTY',
										mode: 'DELETE',
										isControlled: true
									}
								}
							],
							generalActions: [
								{
									id: 'insert',
									name: 'insert',
									title: computed(() => this.Resources.INSERIR43365),
									icon: {
										icon: 'add'
									},
									isInReadOnly: true,
									params: {
										action: vm.openFormAction,
										type: 'form',
										formName: 'F_PROPERTY',
										mode: 'NEW',
										repeatInsertion: false,
										isControlled: true
									}
								},
							],
							generalCustomActions: [
							],
							groupActions: [
							],
							customActions: [
							],
							MCActions: [
							],
							rowClickAction: {
								id: 'RCA_TRA_211',
								name: 'form-F_PROPERTY',
								isVisible: true,
								params: {
									isRoute: true,
									limits: [
										{
											identifier: 'id',
											fnValueSelector: (row) => row.ValCodproperty
										},
									],
									isControlled: true,
									action: vm.openFormAction, type: 'form', mode: 'SHOW', formName: 'F_PROPERTY'
								}
							},
							formsDefinition: {
								'F_PROPERTY': {
									fnKeySelector: (row) => row.Fields.ValCodproperty,
									isPopup: false
								},
							},
							defaultSearchColumnName: 'ValTitle',
							defaultSearchColumnNameOriginal: 'ValTitle',
							defaultColumnSorting: {
								columnName: 'ValSize',
								sortOrder: 'asc'
							}
						},
						groupFilters: [
							{
								id: 'filter_TRA_Menu_21_BUILDINGTY',
								isMultiple: false,
								items: [
									{
										id: 'filter_TRA_Menu_21_BUILDINGTY_1',
										value: computed(() => this.Resources.APARTMENT12665),
										key: '1'
									},
									{
										id: 'filter_TRA_Menu_21_BUILDINGTY_2',
										value: computed(() => this.Resources.HOUSE01993),
										key: '2'
									},
									{
										id: 'filter_TRA_Menu_21_BUILDINGTY_3',
										value: computed(() => this.Resources.OTHER37293),
										key: '3'
									},
									{
										id: 'filter_TRA_Menu_21_BUILDINGTY_4',
										value: computed(() => this.Resources.ALL38603),
										key: '4'
									},
								],
								selected: undefined,
								default: undefined
							},
						],
						globalEvents: ['changed-BROKER', 'changed-CITY', 'changed-PROPERTY'],
						uuid: '2238c9ba-b086-469c-a848-3ab1ce7c5c55',
						allSelectedRows: 'false',
						headerLevel: 1,
						isActiveControl: computed(() => this.isActiveMenu)
					}, this),
				}
			}
		},

		beforeRouteEnter(to, _, next)
		{
			// called before the route that renders this component is confirmed.
			// does NOT have access to `this` component instance,
			// because it has not been created yet when this guard is called!

			next((vm) => vm.updateMenuNavigation(to))
		},

		beforeRouteLeave(to, _, next)
		{
			this.onBeforeRouteLeave(next)
		},

		mounted()
		{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL TRA FORM_CODEJS TRA_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		beforeUnmount()
		{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL TRA COMPONENT_BEFORE_UNMOUNT TRA_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		methods: {
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL TRA FUNCTIONS_JS TRA_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL TRA LISTING_CODEJS TRA_MENU_21]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		}
	}
</script>
