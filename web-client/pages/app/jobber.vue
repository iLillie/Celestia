<script setup lang="ts">
import {useJobs} from "~/stores/job";

const jobStore = useJobs();
const jobs = await jobStore.getAllJobs();

</script>

<template>
    <main class="p-8 grid gap-8 content-start overflow-y-auto max-w-min">
      <div class="grid main gap-8">
        <JobItem v-for="job in jobStore.jobs" :job="job"/>
      </div>
    </main>
</template>

<style>


.main {
  justify-items: start;
  justify-content: start;
  grid-template-columns: 1fr 1fr 1fr;
}

</style>


