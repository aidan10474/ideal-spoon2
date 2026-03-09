import { defineAsyncComponent } from 'vue'

export default {
	install: (app) => {
		app.component('QFormAccountInfo', defineAsyncComponent(() => import('@/views/shared/AccountInfo.vue')))
		app.component('QFormFBroke', defineAsyncComponent(() => import('@/views/forms/FormFBroke/QFormFBroke.vue')))
	}
}
