<template>
  <main class="p-8 grid main gap-8 content-start overflow-y-auto max-w-min">
    <AdvertItem v-for="advert in adverts" :key="advert.id" :advert="advert" @openModal="OpenModal()"></AdvertItem>
    <AdvertModal v-if="modalOpen" @closeModal="() => CloseModal()">
    </AdvertModal>
  </main>
</template>

<style>
body {
  background-color: #F7F7F8;
}

.main {
  justify-items: start;
  justify-content: start;
  grid-template-columns: 1fr 1fr 1fr;
}
</style>

<script lang="ts">
import Vue from 'vue'

export default Vue.extend({
  name: 'Stillinger',
  mounted() {
    console.log(this.adverts);
    if (this.adverts.length > 0) return;

    this.$axios.get("https://localhost:7060/api/job").then(({data}: any) => {
      console.log();
      data.forEach((job: any) => {
        this.$store.commit('advert/add', ({
          id: job.id,
          title: job.title,
          image: "",
          company: "",
          description: job.description,
          location: "",
          adLink: job.postingUrl,
          deadline: job.deadline
        }));
      })
    })
  },
  computed: {
    adverts() {
      return this.$store.state.advert.adverts;
    }
  },
  data() {
    return {
      modalOpen: false,
    }
  },
  methods: {
    OpenModal() {
      this.modalOpen = !this.modalOpen;
    },
    CloseModal() {
      this.modalOpen = false;
    }
  }
})
</script>
