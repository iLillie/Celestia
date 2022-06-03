<script setup lang="ts">
import {useJobs} from "~/stores/job";
import CompanyItem from "~/components/CompanyItem.vue";
import {useCompanies} from "~/stores/company";
import {useFolders} from "~/stores/folder";


const companyStore = useCompanies();
await companyStore.getAllCompanies();



</script>

<template>
    <main class="p-8 grid gap-8 content-start overflow-y-auto max-w-min">
      <h2  class="text-2xl font-bold">Selskaper</h2>
      <div class="grid main gap-8">
        <CompanyItem v-for="company in companyStore.companies" :company="company"/>
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


