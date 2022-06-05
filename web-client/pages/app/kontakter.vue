<script setup lang="ts">
import {useContacts} from "~/stores/contact";

const contactStore = useContacts();
await contactStore.getAllJContact();

</script>

<template>
    <main class="p-8 grid gap-8 content-start overflow-y-auto max-w-min">
      <div class="grid main gap-8">
        <ContactItem v-for="contact in contactStore.contacts" :contact="contact"/>
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


