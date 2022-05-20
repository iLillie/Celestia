<template>
  <div class="grid-container">
    <Sidebar/>
    <div>
      <slot/>
    </div>
  </div>
</template>


<style scoped>
.grid-container {
  display: grid;
  grid-template-columns: auto 1fr;
}
</style>
