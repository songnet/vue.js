<template>
<div>
    <el-card>
    <div slot="header" style="card-header">
    <span>项目</span>
    <el-button type="primary" size="mini" style="float:right;margin-right: 10px;" @click="getUsers()">
          <i class="fa fa-refresh" style="width: 12px;"></i>
    </el-button>
    <el-button type="primary" icon="el-icon-plus" size="mini" style="float:right;margin-right:10px;" @click="dialogFormVisible = true">
    </el-button>
    </div>
    <el-table :data="users" :row-style="hoursStyle">
        <el-table-column  prop="realName" label="成员">
        </el-table-column>
        <el-table-column prop="userName" label="用户名">
        </el-table-column>
        <el-table-column prop="hours" label="工时">
        </el-table-column>
        <el-table-column
      fixed="right"
      label="操作"
      width="100">
      <template slot-scope="scope">
        <el-button @click="handleClick(scope.row)" type="text" size="small">查看</el-button>
        <el-button type="text" size="small">编辑</el-button>
      </template>
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
            this.$http.get("/GetUsers").then((response: any) => {
            this.users = response.data;
            });
        },
        hoursStyle(row:string,index: string){
            
        },
        addProject(model:any){
            this.$http
            .post("/AddUser",this.addForm)
            .then((response:any)=>{
              this.dialogFormVisible = false;
              this.$refs.addForm.resetFields();
              this.getUsers();
            }).catch((error:any)=>{
                if(error.response){
                    console.log(error.response.data);
                    console.log(error.response.status);
                    console.log(error.response.headers);
                }else if(error.request){
                    console.log(error.request);
                }else{
                    console.log("Error", error.message);
                }
                console.log(error.config);
            });
        },
        handleClick(model:any){
        console.log(model);
        }
    }
})
</script>

