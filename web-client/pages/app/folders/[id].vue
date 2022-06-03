<script setup>
import {useJobs} from "~/stores/job";
import {useFolders} from "~/stores/folder";
const route = useRoute();
const folderStore = useFolders();
await folderStore.getFolder(parseInt(route.params.id));
let folder = folderStore.folders.find(f => f.id === parseInt(route.params.id));

</script>

<template>
    <main class="p-8 grid gap-8 content-start overflow-y-auto max-w-min">
        <h2 class="text-2xl font-bold">{{ folder.name }}</h2>
        <JobItem v-for="job in folder.jobs" :job="job"/>
    </main>
</template>

<style>

.main {
  justify-items: start;
  justify-content: start;
  grid-template-columns: 1fr 1fr 1fr;
}

</style>


