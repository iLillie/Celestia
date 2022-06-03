<script setup lang="ts">
import {Contact} from "~/types";

  const props = defineProps<{contact: Contact}>()
</script>

<template>
  <article class="font-normal
                  bg-white text-gray-700 dark:bg-neutral-700 dark:text-portage-50
                  text-lg z-0 p-4 clamped-width rounded-md drop-shadow transition ease-in-out hover:scale-105">
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 text-xl font-bold text-ellipsis whitespace-nowrap overflow-hidden">
        {{ contact.name }}
      </h2>
      <IconButton icon="ri-more-fill"></IconButton>
    </div>
    <p class="text-gray-600 dark:text-neutral-400">
      {{contact.email}}
    </p>
    <p class="text-gray-600 dark:text-neutral-400">
      {{contact.phone}}
    </p>
    <p class="text-gray-600 dark:text-neutral-400">
      {{contact.address}}
    </p>
  </article>
</template>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}
</style>
