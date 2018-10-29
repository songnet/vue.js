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
            users:[
                { realName: 'test',userName:'test',hours:8 },
                { realName: 'songp',userName:'songp',hours:9 },
                { realName: 'test2',userName:'test2',hours:10 }
            ],
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

