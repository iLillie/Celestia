<script setup lang="ts">
  import {Company} from "~/types";

  const props = defineProps<{company: Company}>()
</script>

<template>
  <article style="background-color: #434856" class="text-gray-100 text-lg z-0 p-4 text-md clamped-width rounded-md drop-shadow transition ease-in-out hover:scale-105">
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 text-xl font-bold text-ellipsis whitespace-nowrap overflow-hidden">
        {{ company.name }}
      </h2>
    </div>
    <a v-if="company.homepageUrl != null" :href="company.homepageUrl">
      Hjemmeside
    </a>
    <p class="text-gray-200">
      {{company.address}}
    </p>
  </article>
</template>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}

</style>
