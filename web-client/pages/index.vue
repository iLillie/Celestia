<script setup lang="ts">
import {useJobs} from "~/stores/job";

const store = useJobs();
await store.getAllJobs();



</script>

<template>
  <div>
    <Head>
      <Title>ItJakt</Title>
    </Head>
    {{store.jobs}}
  </div>
</template>

<style>

html {
  background-color: #2C2F38;
  color: white;
}

</style>


