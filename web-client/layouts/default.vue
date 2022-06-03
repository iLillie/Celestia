<template>
  <div class="bg-portage-100 dark:bg-neutral-800 dark:text-neutral-300 grid-container text-slate-700">
    <Sidebar/>
    <div>
      <Header></Header>
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
