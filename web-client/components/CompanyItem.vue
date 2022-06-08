<script setup lang="ts">
  import {Company} from "~/types";

  const props = defineProps<{company: Company}>()
</script>

<template>
  <article class="font-normal z-0 p-4 clamped-width rounded
                  bg-white text-gray-700 dark:bg-neutral-700 dark:text-portage-50
                  transition ease-in-out hover:scale-105">
    <div class="flex justify-between items-center">
      <h2 class="text-xl font-bold max-w-ch-6 text-ellipsis whitespace-nowrap overflow-hidden">
        {{ company.name }}
      </h2>
      <IconButton icon="ri-more-fill"/>
    </div>
    <ul class="flex gap-2 items-center text-green-700 dark:text-green-300">
      <li>
        <span class="ri-road-map-fill"></span>
      </li>
      <li>
        <p class="max-w-ch-6 text-ellipsis whitespace-nowrap overflow-hidden">
          {{ company.address == null ? 'Norge' : company.address }}
        </p>
      </li>
    </ul>
  </article>
</template>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}
</style>
