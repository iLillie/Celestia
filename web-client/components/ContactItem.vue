<script setup lang="ts">
import {Contact} from "~/types";

  const props = defineProps<{contact: Contact}>()
</script>

<template>
  <article class="text-gray-900 bg-white z-0 p-4 clamped-width rounded-md drop-shadow transition ease-in-out hover:scale-105">
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 text-xl font-medium text-ellipsis whitespace-nowrap overflow-hidden">
        {{ contact.name }}
      </h2>
    </div>
    <p >
      {{contact.email}}
    </p>
    <p>
      {{contact.phone}}
    </p>
    <p>
      {{contact.address}}
    </p>
  </article>
</template>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}

</style>
