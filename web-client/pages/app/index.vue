<script lang="ts" setup>
  import {useJobs} from "~/stores/job";
  import CompanyItem from "~/components/CompanyItem.vue";
  import {useCompanies} from "~/stores/company";
  import {useFolders} from "~/stores/folder";
  import {useContacts} from "~/stores/contact";

  const jobStore = useJobs();
  await jobStore.getAllJobs();

  const companyStore = useCompanies();
  await companyStore.getAllCompanies();

  const folderStore = useFolders();
  await folderStore.getAllJFolder();

  const contactStore = useContacts();
  await contactStore.getAllJContact();
</script>

<template>
  <main class="p-8 grid gap-8 content-start overflow-y-auto max-w-min font-medium">
    <h2 class="text-3xl">Jobber</h2>
    <div class="grid main gap-6">
      <JobItem v-for="job in jobStore.jobs.slice(0, 6)" :job="job"/>
    </div>
    <h2 class="text-3xl">Selskaper</h2>
    <div class="grid main gap-8">
      <CompanyItem v-for="company in companyStore.companies" :company="company"/>
    </div>

    <div v-for="folder in folderStore.folders" class="grid gap-8">
      <h2 class="text-3xl font-bold">{{ folder.name }}</h2>
      <JobItem v-for="job in folder.jobs" :job="job"/>
    </div>

    <h2 class="text-3xl font-bold">Kontakter</h2>
    <div class="grid main gap-8">
      <ContactItem v-for="contact in contactStore.contacts" :contact="contact"/>
    </div>
  </main>
</template>

<style>
</style>


