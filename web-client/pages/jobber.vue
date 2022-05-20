<script setup lang="ts">
import {useJobs} from "~/stores/job";

const jobStore = useJobs();
await jobStore.getAllJobs();

</script>

<template>
    <main class="p-8 grid gap-8 content-start overflow-y-auto max-w-min">
      <h2 class="text-2xl font-bold">Jobber</h2>
      <div class="grid main gap-8">
        <JobItem v-for="job in jobStore.jobs" :job="job"/>
      </div>
    </main>
</template>

<style>

html {
  background-color: #2C2F38;
  color: white;
}

.main {
  justify-items: start;
  justify-content: start;
  grid-template-columns: 1fr 1fr 1fr;
}

</style>


