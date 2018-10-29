import Vue from 'vue';
import Router from 'vue-router';
import Main from './views/Main.vue';
import User from './views/Main/User.vue';

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Main',
      component: Main,
      children: [
        {
          path: 'user',
          component: User
        }
      ]

    },
    {
      path: '/user',
      name: 'User',
      component: User
    }
  ],
});
