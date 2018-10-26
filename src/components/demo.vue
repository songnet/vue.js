<template>
  <div class="about">
    <h1>This is an demo page</h1>
    <input v-model="inputValue"/>
    <button v-on:click="submit">提交</button>
    <ul>
      <li v-for="(item,index) of list"
      :key="index"
      v-text="item"
      v-on:click="handeldelete"

      >
      </li>
    </ul>
  </div>
</template>
<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
  data(){
    return{
      inputValue:'',
      list:[],
      index:''
    }
  },
  methods:{
    submit:function(){
      this.list.push(this.inputValue)
      this.inputValue = ''
    },
    handeldelete:function(index){
      this.list.splice(index,1)
    }
  }
})
</script>
