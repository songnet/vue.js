<template>
  <el-container>
    <el-header style="justify-content: space-between;">
      <div>
        <img src="img/logo.png" width="100px;" alt="logo" />
      </div>
      <el-dropdown @command="handleCommand">
        <span class="el-dropdown-link">
          {{userName}}<i class="el-icon-arrow-down el-icon--right"></i>
        </span>
        <el-dropdown-menu slot="dropdown">
          <el-dropdown-item  command="logout">注销</el-dropdown-item>
        </el-dropdown-menu>
      </el-dropdown>
      <div></div>
    </el-header>
    <el-container>
      <el-aside width="110px">
        <el-menu :default-active="$route.path" router class="el-menu-vertical-demo">
          <el-menu-item index="/">
            <i class="fa fa-dashboard"></i>
            <span slot="title">仪表盘</span>
          </el-menu-item>
          <el-menu-item index="/manday">
            <i class="fa fa-coffee"></i>
            <span slot="title">工时</span>
          </el-menu-item>
          <el-menu-item index="/project">
            <i class="fa fa-tasks"></i>
            <span slot="title">项目</span>
          </el-menu-item>
          <el-menu-item index="user">
            <i class="fa fa-users"></i>
            <span slot="title">成员</span>
          </el-menu-item>
          <el-menu-item index="/deploy">
            <i class="fa fa-rocket"></i>
            <span slot="title">部署</span>
          </el-menu-item>
        </el-menu>
      </el-aside>

      <el-main>
        <router-view></router-view>
      </el-main>
    </el-container>
  </el-container>
</template>
<script lang="ts">
import Vue from 'vue'
import User from "@/views/Main/User.vue";
export default Vue.extend({
    name:"dashboard",
    components:{
      User
    },
    data(){
      return {
        userName:"songpeng"
      }
    },
    methods:{
      handleCommand(){

      }
    }
})
</script>
