<template>
  <div class="grid-container">
    <Sidebar/>
    <div>
      <Header/>
      <Nuxt/>
    </div>
  </div>
</template>

<script>
export default {
  name: "default"
}
</script>

<style scoped>
.grid-container {
  display: grid;
  grid-template-columns: auto 1fr;
}
</style>
