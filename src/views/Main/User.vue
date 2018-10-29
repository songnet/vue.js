<template>
    <el-table :data="users" :row-style="hoursStyle">
        <el-table-column prop="realName" label="成员">
        </el-table-column>
        <el-table-column prop="userName" label="用户名">
        </el-table-column>
        <el-table-column prop="hours" label="工时">
        </el-table-column>
      </el-table>
</template>
<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
    name:"user",
    data(){
        return{
            users:[],
            day:"today"
        }
    },
    methods:{
        getUsers(){

        },
        hoursStyle(row,index){
            
        }
    }
})
</script>

