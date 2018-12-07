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
        <el-button @click="editClick(scope.row)" type="text" size="small">编辑</el-button>
        <el-button @click="delClick(scope.row)" type="text" size="small">删除</el-button>
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
    //定义数据模型
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
    //在模板渲染成html后调用，通常是初始化页面完成后，再对html的dom节点进行一些需要的操作。
    mounted(){
    this.getUsers();
    },
    //方法，相当于function
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
        editClick(model:any){
        console.log(model);
        },
        delClick(row:any){
        this.$confirm('此操作将永久删除该文件, 是否继续?', '提示', {
          confirmButtonText: '确定',
          cancelButtonText: '取消',
          type: 'warning'
        }).then(() => {
          this.confirmDel(row);
        }).catch(() => {
          this.$message({
            type: 'info',
            message: '已取消删除'
          });          
        });
      },
        confirmDel(row:any){
            console.log(row.id);
        this.$http
            .delete("/DelUser?userId="+row.id)
            .then((response:any)=>{
                this.$message({
                type: "success",
                message: "删除成功"
                    });
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
        }
    }
})
</script>

