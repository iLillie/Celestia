<template>
  <article class="bg-white z-0 p-4 clamped-width rounded-md drop-shadow transition ease-in-out hover:scale-105">
    <div class="grid place-items-center aspect-video hidden">
      <img :src="advert.image" alt="" class="h-full mx-auto object-contain p-4">
    </div>
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 text-xl font-medium text-ellipsis whitespace-nowrap overflow-hidden">
        {{ advert.title }}
      </h2>
      <button aria-label="details" @click="openModal(advert.id)">
        <span class="ri-more-fill text-2xl"></span>
      </button>
    </div>
    <h3 class="text-lg">
      {{ advert.company }}
    </h3>
    <p class="line-clamp-2 text-ellipsis overflow-hidden mt-2">
      {{ advert.description }}
    </p>
  </article>
</template>

<script>

export default {
  props: {
    advert: Object
  },
  mounted() {
    console.log(this.advert);
  },
  methods: {
    openModal(id) {
      this.$store.commit('modal/update', id);
      this.$emit('openModal');
    }
  }
}
</script>

<style scoped>
.clamped-width {
  width: clamp(20rem, 20vw + 1rem, 22.5rem);
}
</style>
