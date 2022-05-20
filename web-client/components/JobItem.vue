<script setup lang="ts">
  import {Job} from "~/types";

  const props = defineProps<{job: Job}>()
</script>

<template>
  <article class="text-gray-900 bg-white z-0 p-4 clamped-width rounded-md drop-shadow transition ease-in-out hover:scale-105">
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 text-xl font-medium text-ellipsis whitespace-nowrap overflow-hidden">
        {{ job.title }}
      </h2>
    </div>
    <a :href="job.postingUrl">
      Stilling
    </a>
    <p class="">
      {{job.address}}
    </p>

    <p class="line-clamp-2 text-ellipsis overflow-hidden mt-2">
      {{ job.description }}
    </p>



  </article>
</template>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}

</style>
