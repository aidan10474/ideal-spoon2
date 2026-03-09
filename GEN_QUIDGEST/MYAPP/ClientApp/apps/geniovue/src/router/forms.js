import { propsConverter } from './routeUtils.js'

export default function getFormsRoutes()
{
	return [
		{
			path: '/:culture/:system/:module/form/F_BROKE/:mode/:id?',
			name: 'form-F_BROKE',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFBroke/QFormFBroke.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'BROKER',
				humanKeyFields: ['ValName'],
				isPopup: false
			}
		},
	]
}
