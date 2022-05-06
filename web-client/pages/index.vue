<template>
  <div class="flex">
    <Sidebar/>
    <main class="p-8 grid main gap-8 content-start overflow-y-auto">
      <AdvertItem/>
      <AdvertItem/>
      <AdvertItem/>
      <AdvertItem/>
      <AdvertItem/>
      <AdvertItem/>
      <AdvertItem/>
      <AdvertItem/>
      <AdvertItem/>
    </main>
  </div>
</template>

<style>
  body {
    background-color: #F7F7F8;
  }

  .main {
    justify-items: start;
    justify-content: start;
    grid-template-columns: 1fr 1fr 1fr;
  }


</style>

<script lang="ts">
import Vue from 'vue'
import Axios from 'axios';


export default Vue.extend({
  name: 'IndexPage',
})
</script>
