<script setup lang="ts">
import {Job} from "~/types";

  const props = defineProps<{job: Job}>()
</script>

<template>
  <article class="font-normal text-lg z-0 p-4
                  bg-white text-gray-700 dark:bg-neutral-700 dark:text-portage-50
                  clamped-width rounded drop-shadow transition ease-in-out hover:scale-105">
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 text-xl font-bold text-ellipsis whitespace-nowrap overflow-hidden">
        {{ job.title }}
      </h2>
      <IconButton icon="ri-more-fill"></IconButton>
    </div>
    <a :href="job.postingUrl">
      Stilling
    </a>
    <p class="text-gray-600 dark:text-gray-300">
      {{ job.address }}
    </p>
    <p class="text-gray-600 dark:text-gray-300 line-clamp-2 text-ellipsis overflow-hidden mt-2">
      {{ job.description }}
    </p>
  </article>
</template>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}
</style>
