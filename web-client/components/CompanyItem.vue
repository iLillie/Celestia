<script setup lang="ts">
  import {Company} from "~/types";

  const props = defineProps<{company: Company}>()
</script>

<template>
  <article class="text-gray-900 bg-white z-0 p-4 clamped-width rounded-md drop-shadow transition ease-in-out hover:scale-105">
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 text-xl font-medium text-ellipsis whitespace-nowrap overflow-hidden">
        {{ company.name }}
      </h2>
    </div>
    <a :href="company.homepageUrl">
      Hjemmeside
    </a>
    <p class="">
      {{company.address}}
    </p>
  </article>
</template>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}

</style>
