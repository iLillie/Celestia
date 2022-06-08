<script setup lang="ts">
  const route = useRoute();
  const title = computed(() => {
    const path = route.path.split("/")[2];
    return path == null ? "Oversikt" : path.charAt(0).toUpperCase() + path.slice(1);;
  })
</script>


<template>
  <header class="bg-portage-50 dark:bg-neutral-800 dark:text-neutral-200 flex justify-between items-center min-w-max h-20 px-8 sticky top-0 z-40">
    <h1 class="text-2xl font-bold">{{ title }}</h1>
    <p class="text-xl">Lillie</p>
  </header>
</template>
