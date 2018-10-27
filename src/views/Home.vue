<template>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import HelloWorld from '@/components/HelloWorld.vue'; // @ is an alias to /src
import Demo from '@/components/demo.vue';

@Component({
  components: {
    //HelloWorld,
    //Demo,
  },
})
export default class Home extends Vue {}
</script>
