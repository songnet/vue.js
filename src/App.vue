<template>
  <div id="app">
    <el-container>
  <el-header>Header</el-header>
<el-menu :default-active="activeIndex" class="el-menu-demo" mode="horizontal" @select="handleSelect">
  <el-menu-item index="1" to="/about">消息中心</el-menu-item>
  <el-submenu index="2">
    <template slot="title">我的工作台</template>
    <el-menu-item index="2-1">选项1</el-menu-item>
    <el-menu-item index="2-2">选项2</el-menu-item>
    <el-menu-item index="2-3">选项3</el-menu-item>
    <el-submenu index="2-4">
      <template slot="title">选项4</template>
      <el-menu-item index="2-4-1">选项1</el-menu-item>
      <el-menu-item index="2-4-2">选项2</el-menu-item>
      <el-menu-item index="2-4-3">选项3</el-menu-item>
    </el-submenu>
  </el-submenu>
  <el-menu-item index="3" disabled>消息中心</el-menu-item>
  <el-menu-item index="4">订单管理</el-menu-item>
</el-menu>
  <el-main>Main</el-main>
  <el-footer>Footer</el-footer>
</el-container>
    <router-view/>
  </div>
</template>

<style lang="less">
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
.el-header {
    background-color: #B3C0D1;
    color: #333;
    text-align: center;
    line-height: 85px;
  }
  .el-footer {
    background-color: #B3C0D1;
    color: #333;
    text-align: center;
    line-height: 100px;
  }
  .el-main {
    background-color: #E9EEF3;
    color: #333;
    text-align: center;
    line-height: 800px;
  }
  body > .el-container {
    margin-bottom: 40px;
  }
</style>
<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
  data() {
      return {
        activeIndex: '1',
        activeIndex2: '1'
      };
    },
    methods: {
      handleSelect(key, keyPath) {
        console.log(key, keyPath);
      }
    }
})
</script>
