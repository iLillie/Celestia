<template>
    <main class="p-8 grid main gap-8 content-start overflow-y-auto max-w-min">
    </main>
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

export default Vue.extend({
  name: 'IndexPage',
})
</script>
