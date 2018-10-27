import Vue from 'vue';
//引入ele,全局引用
//import VueI18n from 'vue-i18n'
import ElementUI from 'element-ui';
import 'element-ui/lib/theme-chalk/index.css';
import App from './App.vue';
import router from './router';
//import zhLocale from 'element-ui/lib/locale/lang/zh-CN'

Vue.config.productionTip = false;
//使用ele,全局引用
//Vue.use(VueI18n)
Vue.use(ElementUI);
//Vue.use(zhLocale);


new Vue({
  router,
  render: (h) => h(App),
}).$mount('#app');
