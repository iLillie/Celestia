<script setup lang="ts">
import {useJobs} from "~/stores/job";
import CompanyItem from "~/components/CompanyItem.vue";
import {useCompanies} from "~/stores/company";
import {useFolders} from "~/stores/folder";

const jobStore = useJobs();
await jobStore.getAllJobs();

const companyStore = useCompanies();
await companyStore.getAllCompanies();

const folderStore = useFolders();
await folderStore.getAllJFolder();


</script>

<template>
  <div>
    <Head>
      <Title>ItJakt</Title>
    </Head>
    <main class="p-8 grid gap-8 content-start overflow-y-auto max-w-min">
      <h2 class="text-2xl font-bold">Jobber</h2>
      <div class="grid main gap-8">
        <JobItem v-for="job in jobStore.jobs" :job="job"/>
      </div>
      <h2  class="text-2xl font-bold">Selskaper</h2>
      <div class="grid main gap-8">
        <CompanyItem v-for="company in companyStore.companies" :company="company"/>
      </div>

      <div class="grid gap-8"  v-for="folder in folderStore.folders">
        <h2 class="text-2xl font-bold">{{folder.name}}</h2>
        <JobItem v-for="job in folder.jobs" :job="job"/>
      </div>


    </main>
  </div>
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


