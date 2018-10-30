<template>
<div>
    <el-card>
    <div slot="header" style="card-header">
    <span>项目</span>
    <el-button type="primary" icon="el-icon-plus" size="mini" style="float:right;" @click="dialogFormVisible = true">
    </el-button>
    </div>
    <el-table :data="users" :row-style="hoursStyle">
        <el-table-column prop="realName" label="成员">
        </el-table-column>
        <el-table-column prop="userName" label="用户名">
        </el-table-column>
        <el-table-column prop="hours" label="工时">
        </el-table-column>
      </el-table>
      </el-card>
      <el-dialog title="新增用户" :visible.sync="dialogFormVisible">
          <el-form :model="addForm" ref="addForm">
              <el-form-item label="成员" prop="realName">
          <el-input v-model="addForm.realName" auto-complete="off"></el-input>
        </el-form-item>
        <el-form-item label="用户名" prop="userName">
          <el-input v-model="addForm.userName" auto-complete="off"></el-input>
        </el-form-item>
        <el-form-item label="工时" prop="hours">
          <el-input v-model="addForm.hours" auto-complete="off"></el-input>
        </el-form-item>
          </el-form>
          <div slot="footer" class="dialog-footer">
        <el-button @click="dialogFormVisible = false">取 消</el-button>
        <el-button type="primary" @click="addProject('addForm')">确 定</el-button>
      </div>
      </el-dialog>
      </div>
</template>
<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
export default Vue.extend({
    name:"user",
    data(){
        return{
            users:[],
            dialogFormVisible:false,
            day:"today",
            addForm:{
                realName:"",
                userName:"",
                hours:""
            }
        }
    },
    mounted(){
    this.getUsers();
    },
    methods:{
        getUsers(){
            this.$http.get("/GetUsers").then(response => {
            this.users = response.data;
            });
        },
        hoursStyle(row,index){
            
        },
        addProject(model){
            console.log(model);
            console.log(this.addForm);
            this.users.push(this.addForm);
            this.dialogFormVisible = false;
            this.$refs.addForm.resetFields();
        }
    }
})
</script>

