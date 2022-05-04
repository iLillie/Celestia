<template>
  <div>
    {{message}}
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Axios from 'axios';


export default Vue.extend({
  name: 'IndexPage',
  data: () => ({
    message: ""
  }),
   asyncData(ctx: any): Promise<object | void> | object | void {
     return Axios.get('http://localhost:5000/api/home')
       .then(({data}) => {
         return { message: data }
       })
   }
})
</script>
